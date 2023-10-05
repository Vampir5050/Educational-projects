namespace WeatherForecast.Models
{
    public class WeatherApiResponse
    {
        public Weather[] weather { get; set; }
        public Main main { get; set; }
        public Wind wind { get; set; }
        public int dt { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
        public string message { get; set; }
    }
}