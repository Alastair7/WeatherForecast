using WeatherForecasts.Domain.Models;

namespace WeatherForecasts.Domain.Abstractions
{
    public interface IWeatherForecastRepository
    {
        WeatherForecast[] GetForecasts();
    }
}
