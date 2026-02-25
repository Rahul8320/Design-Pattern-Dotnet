using WeatherStation.Interfaces;
using WeatherStation.Models;

namespace WeatherStation.Services;

public class HeatIndexDisplay : IObserver, IDisplayElement
{
    private readonly ISubject _subject;

    private double Temperature { get; set; }
    private double Humidity { get; set; }
    private double HeatIndex => CalculateHeatIndex(Temperature, Humidity);

    public HeatIndexDisplay(ISubject subject)
    {
        _subject = subject;
        _subject.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine($"Heat index is {Math.Round(HeatIndex, 2)}");
    }

    public void Update(Weather weather)
    {
        Temperature = weather.Temperature;
        Humidity = weather.Humidity;

        Display();
    }

    private static double CalculateHeatIndex(double T, double RH)
    {
        double HI = -42.379 + 2.04901523 * T + 10.14333127 * RH - .22475541 * T * RH - .00683783 * T * T - .05481717 * RH * RH + .00122874 * T * T * RH + .00085282 * T * RH * RH - .00000199 * T * T * RH * RH;

        return HI;
    }
}
