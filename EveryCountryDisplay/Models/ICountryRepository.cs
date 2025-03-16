using EveryCountryDisplay.Models.Pocos;

namespace EveryCountryDisplay.Models
{
    public interface ICountryRepository
    {
        Task<List<Country>> GetCountries();

        Task<string> LoadJson();

        List<Country> DeserializeJson(string json);
    }
}
