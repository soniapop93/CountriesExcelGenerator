using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CountriesExcelGenerator.CountriesAPI
{
    public class Maps
    {
        [JsonPropertyName("googleMaps")]
        string googleMapsUrl { get; set; }
    }
}
