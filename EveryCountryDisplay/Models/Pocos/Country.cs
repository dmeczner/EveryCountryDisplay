namespace EveryCountryDisplay.Models.Pocos
{
    public class Country
    {
        public string? Cca3 { get; set; }

        public Name? Name { get; set; } = new();

        public List<string>? Continents { get; set; }=[];

        public string? Region { get; set; }

        public List<string>? Capital { get; set; }=[];

        public Dictionary<string, double>? Gini { get; set; } = [];

        public Flags? Flags { get; set; } = new();

        public Dictionary<string, Currency>? Currencies { get; set; } = [];
    }
}
