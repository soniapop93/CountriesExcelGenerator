using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountriesExcelGenerator.CountriesAPI;
using IronXL;
using IronXL.Styles;

namespace CountriesExcelGenerator.Excel
{
    public class GenerateExcel
    {
        private static List<string> columnNames = new List<string>()
            {
                "Country Common Name",
                "Country Official Name",
                "Domains",
                "Independent",
                "United Nations Member",
                "Currencies",
                "Capital Name",
                "Region",
                "Subregion",
                "Languages",
                "Area",
                "Flag",
                "Google Maps URL",
                "Population",
                "Timezones",
                "Continents",
                "Flag PNG URL"
            };

        public static void createExcelDoc(string authorName, List<Country> countriesList, string path)
        {
            string fileName = String.Format("Countries_Information_{0}.xls", DateTime.Now.ToString("dd-MM-yyyy"));
            Console.WriteLine("Creating Excel document with name {0}" + fileName);

            WorkBook xlsDocument = WorkBook.Create(ExcelFileFormat.XLS);
            xlsDocument.Metadata.Author = authorName;
            WorkSheet xlsSheet = xlsDocument.CreateWorkSheet("Countries");
            createColumns(xlsSheet);
            fillRows(xlsSheet, countriesList);
            xlsDocument.SaveAs(path + fileName);
            Console.WriteLine("Excel document is saved here: " + path);
        }

        public static WorkSheet createColumns(WorkSheet xlxSheet)
        {
            Console.WriteLine("Generating columns ...");
            int count = 0;

            /* ASCII dec used in this for to generate Excel columns from A to number of column items*/
            for (int c = 65; c <= 90; c++)
            {
                if (count >= columnNames.Count() )
                {
                    break;
                }
                xlxSheet[(char)c + "1"].Value = columnNames[count];
                xlxSheet[(char)c + "1"].Style.BottomBorder.SetColor("#000000");
                xlxSheet[(char)c + "1"].Style.BottomBorder.Type = BorderType.Medium;
                xlxSheet[(char)c + "1"].Style.Font.Bold = true;
                xlxSheet[(char)c + "1"].Style.SetBackgroundColor("#1ad4a7");
                xlxSheet[(char)c + "1"].Style.ShrinkToFit = true;
                count++;
            }

            return xlxSheet;
        }

        public static WorkSheet fillRows(WorkSheet xlxSheet, List<Country> countriesList)
        {
            Console.WriteLine("FIlling rows ...");
            // Generate list with letter of alphabet, from A - Z -> used for Excel columns
            List<char> columnIndexes = Enumerable.Range(65, 90).Select(c => (char)c).ToList<char>();

            for (int i = 0; i < countriesList.Count(); i++)
            {
                string cellIndex = (i + 2).ToString();


                // Get the name values from the countryCurrency dictionary
                List<string> currenciesList = new List<string>();
                if (countriesList[i].countryCurrency != null)
                {
                    currenciesList = countriesList[i].countryCurrency.Values.ToList().Select(c => c.currencyName).ToList();
                }
                else
                {
                    currenciesList.Add("No information available");
                }


                // Get the languages values from dictionary
                List<string> languagesList = new List<string>();
                if (countriesList[i].countryLanguages != null)
                {
                    languagesList = countriesList[i].countryLanguages.Values.ToList();
                }
                else
                {
                    languagesList.Add("No information available");
                }

                string domains = "No information available";
                if (countriesList[i].topLevelDomain != null)
                {
                    domains = String.Join(",", countriesList[i].topLevelDomain);
                }

                // Fill Cell Rows
                xlxSheet[columnIndexes[0] + cellIndex].Value = countriesList[i].name.commonName; // Country Common Name
                xlxSheet[columnIndexes[1] + cellIndex].Value = countriesList[i].name.officialName; // Country Official Name
                xlxSheet[columnIndexes[2] + cellIndex].Value = domains; //Domains
                xlxSheet[columnIndexes[3] + cellIndex].Value = countriesList[i].independent ? "Yes" : "No"; // Independent
                xlxSheet[columnIndexes[4] + cellIndex].Value = countriesList[i].unitedNationsMember ? "Yes" : "No"; // United Nations Member
                xlxSheet[columnIndexes[5] + cellIndex].Value = String.Join(",", currenciesList); // Currencies
                xlxSheet[columnIndexes[6] + cellIndex].Value = countriesList[i].capital; // Capital Name
                xlxSheet[columnIndexes[7] + cellIndex].Value = countriesList[i].region; // Region
                xlxSheet[columnIndexes[8] + cellIndex].Value = countriesList[i].subregion; // Subregion
                xlxSheet[columnIndexes[9] + cellIndex].Value = String.Join(",", languagesList); // Languages
                xlxSheet[columnIndexes[10] + cellIndex].Value = countriesList[i].area.ToString(); // Area
                xlxSheet[columnIndexes[11] + cellIndex].Value = countriesList[i].flag; // Flag
                xlxSheet[columnIndexes[12] + cellIndex].Value = countriesList[i].maps.googleMapsUrl; // Google Maps URL
                xlxSheet[columnIndexes[13] + cellIndex].Value = countriesList[i].population.ToString(); // Population
                xlxSheet[columnIndexes[14] + cellIndex].Value = String.Join(",", countriesList[i].timezones); // Timezones
                xlxSheet[columnIndexes[15] + cellIndex].Value = String.Join(",", countriesList[i].continents); // Continents
                xlxSheet[columnIndexes[16] + cellIndex].Value = countriesList[i].flags.flagPNGURL; // Flag PNG URL

            }

            return xlxSheet;
        }
    }
}
