using WeatherStation.Services;

var weatherData = new WeatherData();

var display1 = new CurrentConditionDisplay(weatherData);
var display2 = new CurrentConditionDisplay(weatherData);

weatherData.SetMeasurements(80, 65, 30.4);
weatherData.SetMeasurements(82, 70, 29.2);
weatherData.SetMeasurements(78, 90, 29.2);
