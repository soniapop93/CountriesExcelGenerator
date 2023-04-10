using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesExcelGenerator.CountriesAPI
{
    public class Country
    {
        string name { get; set; }
        string topLevelDomain { get; set; }
        bool independent { get; set; }
        bool unitedNationsMember { get; set; }
        CountryCurrency countryCurrency { get; set; }
        string capital { get; set; }
        string region { get; set; }
        string subregion { get; set; }
        List<CountryLanguage> countryLanguages { get; set; }
        double area { get; set; }
        string flag { get; set; }
        string googleMapsURL { get; set; }
        double population { get; set; }
        string timezone { get; set; }
        List<CountryContinent> countryContinents { get; set; }
        string flagURLPicture { get; set; }

        public Country(string name, string topLevelDomain, bool independent, bool unitedNationsMember, CountryCurrency countryCurrency, string capital, string region, string subregion, List<CountryLanguage> countryLanguages, double area, string flag, string googleMapsURL, double population, string timezone, List<CountryContinent> countryContinents, string flagURLPicture)
        {
            this.name = name;
            this.topLevelDomain = topLevelDomain;
            this.independent = independent;
            this.unitedNationsMember = unitedNationsMember;
            this.countryCurrency = countryCurrency;
            this.capital = capital;
            this.region = region;
            this.subregion = subregion;
            this.countryLanguages = countryLanguages;
            this.area = area;
            this.flag = flag;
            this.googleMapsURL = googleMapsURL;
            this.population = population;
            this.timezone = timezone;
            this.countryContinents = countryContinents;
            this.flagURLPicture = flagURLPicture;
        }
    }
}