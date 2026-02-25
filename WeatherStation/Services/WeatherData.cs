using WeatherStation.Interfaces;
using WeatherStation.Models;

namespace WeatherStation.Services;

public class WeatherData : ISubject
{
    private readonly List<IObserver> _observers = [];
    private Weather Weather { get; set; } = new Weather(0, 0, 0);

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(weather: Weather);
        }
    }

    public void RegisterObserver(IObserver observer)
    {
        var index = _observers.IndexOf(observer);

        if (index == -1)
        {
            _observers.Add(observer);
        }
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void MeasurementChanged()
    {
        NotifyObservers();
    }

    public void SetMeasurements(double temp, double humidity, double pressure)
    {
        Weather = new Weather(Temperature: temp, Humidity: humidity, Pressure: pressure);

        MeasurementChanged();
    }
}
