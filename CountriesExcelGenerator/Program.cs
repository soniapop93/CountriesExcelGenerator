using System;
using CountriesExcelGenerator.CountriesAPI;
using CountriesExcelGenerator.Excel;
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

              Package IronXL, that generates Excel file, doesn't work
              if the script is not run in debug mode. 
              In order for it to work in Release mode, the package needs
              to have the license enabled.

           =============================================================
           =============================================================
        */

        Console.WriteLine("------------------------ SCRIPT STARTED ------------------------");
        try
        {
            string response = RequestManager.getCountriesInfo("https://restcountries.com/v3.1/all");

            List<Country> countriesList = CountriesRequestParser.apiFilterResponse(response);

            string path = @"C:\Users\" + System.Environment.UserName + @"\Desktop\";

            GenerateExcel.createExcelDoc("CountriesExcelGenerator", countriesList, path);
        }
        catch (Exception e)
        {
            Console.WriteLine("There was an exception: {0} {1} {2} {3}", e.Message, "\n", e.Source, "\n", e.StackTrace);
        }
        Console.WriteLine("------------------------ SCRIPT FINISHED ------------------------");
    }
}