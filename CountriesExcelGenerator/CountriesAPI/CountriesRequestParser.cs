using System.Text.Json.Nodes;
using System.Collections.Generic;
using System.Text.Json;


namespace CountriesExcelGenerator.CountriesAPI
{
    public class CountriesRequestParser
    {
        public static List<Country> apiFilterResponse(string response)
        {
            Console.WriteLine("Deserializing data response ...");
            List<Country> country_jobject = JsonSerializer.Deserialize<List<Country>>(response);

            return country_jobject;
        }
    }
}
