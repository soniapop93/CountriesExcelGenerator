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

        public static void createExcelDoc(string authorName, List<Country> countriesList)
        {
            string fileName = String.Format("Countries_Information_{0}.xls", DateTime.Now.ToString("dd-MM-yyyy"));
            
            WorkBook xlsDocument = WorkBook.Create(ExcelFileFormat.XLS);
            xlsDocument.Metadata.Author = authorName;
            WorkSheet xlsSheet = xlsDocument.CreateWorkSheet("Countries");
            createColumns(xlsSheet);
            fillRows(xlsSheet, countriesList);
            xlsDocument.SaveAs(fileName);
        }

        public static WorkSheet createColumns(WorkSheet xlxSheet)
        {
            int count = 0;

            /* ASCII dec used in this for to generate Excel columns from A to number of column items*/
            for (int c = 65; c <= 90; c++)
            {
                Console.WriteLine(count);
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
            // Generate list with letter of alphabet, from A - Z -> used for Excel columns
            List<char> columnIndexes = Enumerable.Range(65, 90).Select(c => (char)c).ToList<char>();

            for (int i = 0; i < countriesList.Count(); i++)
            {
                string cellIndex = (i + 2).ToString();
                xlxSheet[columnIndexes[0] + cellIndex].Value = countriesList[i].name.commonName; // Country Common Name
                xlxSheet[columnIndexes[1] + cellIndex].Value = countriesList[i].name.officialName; // Country Official Name
                xlxSheet[columnIndexes[2] + cellIndex].Value = String.Join(",", countriesList[i].topLevelDomain); //Domains
                xlxSheet[columnIndexes[3] + cellIndex].Value = String.Join(",", countriesList[i].topLevelDomain);
            }

            return xlxSheet;
        }
    }
}
