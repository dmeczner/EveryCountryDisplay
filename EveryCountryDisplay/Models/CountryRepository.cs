using EveryCountryDisplay.Models.Pocos;
using System.Text.Json;

namespace EveryCountryDisplay.Models
{
    public class CountryRepository : ICountryRepository
    {
        private readonly HttpClient _httpClient;

        private const string ALL_COUNTRIES_URL = "https://restcountries.com/v3.1/all";

        public CountryRepository()
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
            };
            _httpClient = new HttpClient(handler);
        }

        public async Task<List<Country>> GetCountries()
        {
            var json = await LoadJson();
            return DeserializeJson(json);
        }

        public async Task<string> LoadJson()
        {
            return await _httpClient.GetStringAsync(ALL_COUNTRIES_URL);
        }

        public List<Country> DeserializeJson(string json)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var countries = JsonSerializer.Deserialize<List<Country>>(json, options);
            return SortCountriesByABC(countries);
        }

        private List<Country> SortCountriesByABC(IEnumerable<Country> countries)
        {
            return [.. countries.OrderBy(x => x.Name.Official)];
        }
    }
}
