namespace Weather.model
{
    public class WeatherData
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public double Temperature { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public DateTime Date { get; set; }
    }
}
