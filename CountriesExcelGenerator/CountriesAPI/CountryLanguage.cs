using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesExcelGenerator.CountriesAPI
{
    public class CountryLanguage
    {
        string countryLanguage { get; set; }

        public CountryLanguage(string countryLanguage)
        {
            this.countryLanguage = countryLanguage;
        }
    }
}
