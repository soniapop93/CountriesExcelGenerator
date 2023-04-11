using System;
using CountriesExcelGenerator.CountriesAPI;
using CountriesExcelGenerator.Utilities;

public class Program
{
    public static void Main(string[] args)
    {
        /*
           =============================================================
           =============================================================
              The API endoint used in this script is free to use.
              https://restcountries.com/v3.1/all
           =============================================================
           =============================================================
        */
        string response = RequestManager.getCountriesInfo("https://restcountries.com/v3.1/all");

        CountriesRequestParser.apiFilterResponse(response);
    }
}