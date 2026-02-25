using WeatherStation.Models;

namespace WeatherStation.Interfaces;

public interface IObserver
{
    public void Update(Weather weather);
}
