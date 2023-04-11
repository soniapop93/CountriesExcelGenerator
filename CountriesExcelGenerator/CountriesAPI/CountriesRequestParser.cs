using System.Text.Json.Nodes;
using System.Collections.Generic;
using System.Text.Json;


namespace CountriesExcelGenerator.CountriesAPI
{
    public class CountriesRequestParser
    {
        public static void apiFilterResponse(string response)
        {
            List<Country> country_jobject = JsonSerializer.Deserialize<List<Country>>(response);

            Console.WriteLine(country_jobject);
        }
    }
}
