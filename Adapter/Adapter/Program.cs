using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryXml countryXml = new CountryXml();
            ICountryJson countryJson = new AdapterCountryJson(countryXml);
            var resp = countryJson.GetContinent();
            Console.WriteLine(resp);
        }
    }
}