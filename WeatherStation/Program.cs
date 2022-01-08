// See https://aka.ms/new-console-template for more information

using WeatherStation;

var weatherData = new WeatherData();

var currentDisplay = new CurrentConditionsDisplay(weatherData);
var statisticsDisplay = new StatisticsDisplay(weatherData);
var forecastDisplay = new ForecastDisplay(weatherData);


weatherData.SetMeasurements(80, 65,30.4f);
weatherData.SetMeasurements(82,70,29.2f);
weatherData.SetMeasurements(78,90,29.2f);