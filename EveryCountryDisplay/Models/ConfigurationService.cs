namespace EveryCountryDisplay.Models
{
    public class ConfigurationService
    {
        private readonly IConfiguration _configuration;

        public ConfigurationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetBackgroundColor()
        {
            return _configuration["Background"] ?? "white"; // Default to white if not set
        }
    }
}
