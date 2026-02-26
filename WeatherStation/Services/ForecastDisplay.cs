using System.ClientModel;
using OpenAI;
using OpenAI.Chat;
using WeatherStation.Interfaces;
using WeatherStation.Models;

namespace WeatherStation.Services;

public class ForecastDisplay : IObserver, IDisplayElement
{
    private readonly ISubject _subject;

    private Weather Weather { get; set; }

    public ForecastDisplay(ISubject subject)
    {
        _subject = subject;
        _subject.RegisterObserver(this);
        Weather = new Weather(0, 0, 0);
    }

    public void Display()
    {
        string message = GenerateForecastText(weather: Weather);
        Console.WriteLine($"Forecast: {message}");
    }

    public void Update(Weather weather)
    {
        Weather = weather;

        Display();
    }

    private string GenerateForecastText(Weather weather)
    {
        try
        {
            var client = new ChatClient(
                model: "liquid/lfm2.5-1.2b",
                credential: new ApiKeyCredential("Not Required"),
                options: new OpenAIClientOptions()
                {
                    Endpoint = new Uri("http://127.0.0.1:1234/v1")
                }
            );

            ChatMessage[] messages = [
                ChatMessage.CreateSystemMessage("You are a weather forecast assistant. Your task it to defined the forecast text for the user based on the temperature, humidity and pressure value provided to you. Don't repeat the weather data provided to you. Keep this forecast message/text short, one liner and to the point."),
                ChatMessage.CreateUserMessage($"My current weather details: {weather}. Give me the weather forecast based on this data.")
            ];

            var completion = client.CompleteChat(messages);
            return completion.Value.Content[0].Text;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred during generating forecast message. Error: {ex.Message}");
            return Weather.Temperature switch
            {
                > 80 => "Improve weather on the way",
                > 75 => "Watch out for cooler, rainy weather",
                _ => "More of the same",
            };
        }
    }
}
