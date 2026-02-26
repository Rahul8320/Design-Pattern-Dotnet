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
            var llmChat = new LlmChat();

            ChatMessage[] messages = [
                ChatMessage.CreateSystemMessage("You are a weather forecast assistant. Your task it to defined the forecast text for the user based on the temperature, humidity and pressure value provided to you. Don't repeat the weather data provided to you. Keep this forecast message/text short, one liner and to the point."),
                ChatMessage.CreateUserMessage($"My current weather details: {weather}. Give me the weather forecast based on this data.")
            ];

            return llmChat.Chat(messages);
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
