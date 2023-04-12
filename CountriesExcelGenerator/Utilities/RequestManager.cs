using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace CountriesExcelGenerator.Utilities
{
    public class RequestManager
    {
        public static string getCountriesInfo(string apiEndpoint)
        {
            Console.WriteLine("Will request response from endpoint: {0}", apiEndpoint);
            string responseContent = "";
            RestClient client = new RestClient(apiEndpoint);

            RestRequest request = new RestRequest()
            {
                Method = Method.Get
            };
            RestResponse<string> response = client.Execute<string>(request);

            if (response.Content != null)
            {
                responseContent = response.Content;
            }
            return responseContent;
        }
    }
}