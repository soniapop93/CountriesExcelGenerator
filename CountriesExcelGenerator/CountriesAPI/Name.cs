using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CountriesExcelGenerator.CountriesAPI
{
    public class Name
    {
        [JsonPropertyName("common")]
        public string commonName { get; set; }
        [JsonPropertyName("official")]
        public string officialName { get; set; }
    }
}
