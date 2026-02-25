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
        string message = Weather.Temperature switch
        {
            > 80 => "Improve weather on the way",
            > 75 => "Watch out for cooler, rainy weather",
            _ => "More of the same",
        };

        Console.WriteLine($"Forecast: {message}");
    }

    public void Update(Weather weather)
    {
        Weather = weather;

        Display();
    }
}
