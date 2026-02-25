using WeatherStation.Interfaces;

namespace WeatherStation.Services;

public class WeatherData : ISubject
{
    private readonly List<IObserver> _observers = [];

    private double Temperature { get; set; }
    private double Humidity { get; set; }
    private double Pressure { get; set; }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(temp: Temperature, humidity: Humidity, pressure: Pressure);
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
        Temperature = temp;
        Humidity = humidity;
        Pressure = pressure;

        MeasurementChanged();
    }
}
