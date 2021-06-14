using System;
using System.IO;
using System.Net;
namespace Adapter
{
    public class CountryXml
    {

        private static HttpWebRequest CreateSoaRequest()
        {
            var webRequest = (HttpWebRequest) WebRequest
                .Create("http://webservices.oorsprong.org/websamples.countryinfo/CountryInfoService.wso");

            webRequest.ContentType = @"text/xml; charset=utf-8";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }
        public string GetCountry()
        {
            var result = "";
            var request = CreateSoaRequest();
            string sopStr = @"<?xml version=""1.0"" encoding=""utf-8""?>
                <soap12:Envelope xmlns:soap12=""http://www.w3.org/2003/05/soap-envelope"">
                <soap12:Body>
                <ListOfCountryNamesByName xmlns=""http://www.oorsprong.org/websamples.countryinfo"">
                </ListOfCountryNamesByName>
                </soap12:Body>
                </soap12:Envelope>";

            using (Stream stream = request.GetRequestStream())
            {
                using (StreamWriter streamWriter = new StreamWriter(stream))
                {
                    streamWriter.Write(sopStr);
                }
            }

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                    {
                        result = rd.ReadToEnd();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return result;
        }
    }
}