using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CountriesExcelGenerator.CountriesAPI
{
    public class CountryCurrency
    {
        [JsonPropertyName("name")]
        public string currencyName { get; set; }

        [JsonPropertyName("symbol")]
        public string currencySymbol { get; set; }

        public CountryCurrency(string currencyName, string currencySymbol)
        {
            this.currencyName = currencyName;
            this.currencySymbol = currencySymbol;
        }
    }

}
