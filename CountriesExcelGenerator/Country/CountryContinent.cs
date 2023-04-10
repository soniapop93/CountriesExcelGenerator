using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesExcelGenerator.CountriesAPI
{
    public class CountryContinent
    {
        string continentName { get; set; }

        public CountryContinent(string continentName)
        {
            this.continentName = continentName;
        }
    }
}
