using Microsoft.Extensions.Options;
using WeatherForecast.Models;
using WeatherForecast.Options;
using Newtonsoft.Json;


namespace WeatherForecast.Services
{
    public class WeatherApiServices : IWeatherApiServices
    {
        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
        private HttpClient httpClient { get; set; }

        public WeatherApiServices(IHttpClientFactory httpClientFactory,IOptions<WeatherApiOptions> options)
        {
            BaseUrl = options.Value.BaseUrl;
            ApiKey = options.Value.ApiKey;
            httpClient = httpClientFactory.CreateClient();
        }
        public async Task<WeatherApiResponse> SearchByCityAsync(string city)
        {
            var response = await httpClient.GetAsync($"{BaseUrl}data/2.5/weather?q={city}&appid={ApiKey}&units=metric");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<WeatherApiResponse>(json);
            if(result.cod!=200)
            {
                throw new Exception(result.message);
            }
            return result;
        }
    }
}
