using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CountriesExcelGenerator.CountriesAPI
{
    public class Country
    {
        public Name name { get; set; }

        [JsonPropertyName("tld")]
        public List<string> topLevelDomain { get; set; }
        public bool independent { get; set; }

        [JsonPropertyName("unMember")]
        public bool unitedNationsMember { get; set; }

        [JsonPropertyName("currencies")]
        public Dictionary<string, CountryCurrency> countryCurrency { get; set; }
        public List<string> capital { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }

        [JsonPropertyName("languages")]
        public Dictionary<string, string> countryLanguages { get; set; }
        public double area { get; set; }
        public string flag { get; set; }
        public Maps maps { get; set; }
        public double population { get; set; }
        public List<string> timezones { get; set; }
        public List<string> continents { get; set; }
        public Flag flags { get; set; }
    }
}