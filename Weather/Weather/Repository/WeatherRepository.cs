using Dapper;
using Npgsql;
using Weather.model;

namespace Weather.Repository
{
    public class WeatherRepository
    {
        private readonly string _connectionString;

        public WeatherRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task SaveWeatherDataAsync(WeatherData weatherData)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            var sql = "INSERT INTO WeatherData (Location, Temperature, Description, Icon, Date) VALUES (@Location, @Temperature, @Description, @Icon, @Date)";
            await connection.ExecuteAsync(sql, weatherData);
        }

        public async Task<IEnumerable<WeatherData>> GetWeatherDataAsync(string location, DateTime from, DateTime to)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            var sql = "SELECT * FROM WeatherData WHERE Location = @Location AND Date BETWEEN @From AND @To";
            return await connection.QueryAsync<WeatherData>(sql, new { Location = location, From = from, To = to });
        }
    }
}
