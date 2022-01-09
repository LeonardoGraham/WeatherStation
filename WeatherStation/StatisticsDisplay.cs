namespace WeatherStation;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    private float _maxTemp = 0.0f;
    private float _minTemp = 200;
    private float _tempSum = 0.0f;
    private int _numReadings;
    private WeatherData _weatherData;

    public StatisticsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        var temperature = _weatherData.Temperature;
        _tempSum += temperature;
        _numReadings++;

        if (temperature > _maxTemp)
        {
            _maxTemp = temperature;
        }

        if (temperature < _minTemp)
        {
            _minTemp = temperature;
        }
        
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Avg/Max/Min temperature = " + (_tempSum / _numReadings) + 
                          "/" + _maxTemp + "/" + _minTemp);
    }
}