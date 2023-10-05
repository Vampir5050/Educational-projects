using WeatherForecast.Models;

namespace WeatherForecast.Services
{
    public interface IWeatherApiServices
    {
        Task<WeatherApiResponse> SearchByCityAsync(string city);
    }
}
