using WeatherStation.Interfaces;
using WeatherStation.Models;

namespace WeatherStation.Services;

public class CurrentConditionDisplay : IObserver, IDisplayElement
{
    private readonly ISubject _subject;

    private double Temperature { get; set; }
    private double Humidity { get; set; }

    public CurrentConditionDisplay(ISubject subject)
    {
        _subject = subject;
        _subject.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {Temperature} F degree and {Humidity} % humidity.");
    }

    public void Update(Weather weather)
    {
        Temperature = weather.Temperature;
        Humidity = weather.Humidity;
        Display();
    }
}
