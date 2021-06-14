using System.Xml;
using Newtonsoft.Json;

namespace Adapter
{
    public class AdapterCountryJson : ICountryJson
    {
        private readonly CountryXml _countryXml;

        public AdapterCountryJson(CountryXml countryXml)
        {
            _countryXml = countryXml;
        }
        public string GetContinent()
        {
            var country = _countryXml.GetCountry();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(country);
            return JsonConvert.SerializeXmlNode(doc);

          
        }
    }
}