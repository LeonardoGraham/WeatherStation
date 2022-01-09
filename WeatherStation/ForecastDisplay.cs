using WeatherStation;

public class ForecastDisplay : IObserver, IDisplayElement
{
    private float _currentPressure = 29.92f;
    private float _lastPressure;
    private readonly WeatherData _weatherData;

    public ForecastDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        var pressure = _weatherData.Pressure;
        _lastPressure = _currentPressure;
        _currentPressure = pressure;
        
        Display();
    }

    public void Display()
    {
        Console.Write("Forecast: ");

        if (_currentPressure > _lastPressure)
        {
            Console.WriteLine("Improving weather on the way!");
        }
        else if (Math.Abs(_currentPressure - _lastPressure) < double.Epsilon)
        {
            Console.WriteLine("More of the same");
        }
        else if (_currentPressure < _lastPressure)
        {
            Console.WriteLine("Watch out for cooler, rainy weather");
        }
    }
}