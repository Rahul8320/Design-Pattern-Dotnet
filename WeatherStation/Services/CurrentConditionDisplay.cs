using WeatherStation.Interfaces;

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

    public void Update(double temp, double humidity, double _)
    {
        Temperature = temp;
        Humidity = humidity;
        Display();
    }
}
