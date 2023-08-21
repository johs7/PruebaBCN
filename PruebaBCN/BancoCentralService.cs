using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PruebaBCN
{
    public class BancoCentralService
    {
        public async Task<XDocument> GetExchangeRatesForMonthAsync(int year, int month)
        {
            string serviceUrl = "https://servicios.bcn.gob.ni/Tc_Servicio/ServicioTC.asmx";
            string soapAction = "http://servicios.bcn.gob.ni/RecuperaTC_Mes";

            using (HttpClient client = new HttpClient())
            {
                string soapEnvelope = $@"<?xml version=""1.0"" encoding=""utf-8""?>
        <soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
            <soap:Body>
                <RecuperaTC_Mes xmlns=""http://servicios.bcn.gob.ni/"">
                    <Ano>{year}</Ano>
                    <Mes>{month}</Mes>
                </RecuperaTC_Mes>
            </soap:Body>
        </soap:Envelope>";

                StringContent content = new StringContent(soapEnvelope, Encoding.UTF8, "text/xml");
                client.DefaultRequestHeaders.Add("SOAPAction", soapAction);

                HttpResponseMessage response = await client.PostAsync(serviceUrl, content);
                string responseContent = await response.Content.ReadAsStringAsync();

                XDocument xDoc = XDocument.Parse(responseContent);
                return xDoc;
            }
        }
      
        public async Task<double> GetExchangeRateForDayAsync(int year, int month, int day)
        {
            string serviceUrl = "https://servicios.bcn.gob.ni/Tc_Servicio/ServicioTC.asmx";
            string soapAction = "http://servicios.bcn.gob.ni/RecuperaTC_Dia";

            using (HttpClient client = new HttpClient())
            {
                string soapEnvelope = $@"<?xml version=""1.0"" encoding=""utf-8""?>
        <soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
            <soap:Body>
                <RecuperaTC_Dia xmlns=""http://servicios.bcn.gob.ni/"">
                    <Ano>{year}</Ano>
                    <Mes>{month}</Mes>
                    <Dia>{day}</Dia>
                </RecuperaTC_Dia>
            </soap:Body>
        </soap:Envelope>";

                StringContent content = new StringContent(soapEnvelope, Encoding.UTF8, "text/xml");
                client.DefaultRequestHeaders.Add("SOAPAction", soapAction);

                HttpResponseMessage response = await client.PostAsync(serviceUrl, content);
                string responseContent = await response.Content.ReadAsStringAsync();

                XDocument xDoc = XDocument.Parse(responseContent);

                XNamespace soapNs = "http://schemas.xmlsoap.org/soap/envelope/";
                XNamespace responseNs = "http://servicios.bcn.gob.ni/";

                var responseElement = xDoc.Descendants(soapNs + "Body")
                                         .Descendants(responseNs + "RecuperaTC_DiaResponse")
                                         .FirstOrDefault();

                if (responseElement != null)
                {
                    double exchangeRate = double.Parse(responseElement.Element(responseNs + "RecuperaTC_DiaResult").Value);
                    return exchangeRate;
                }
                else
                {
                    throw new Exception("No se pudo obtener el tipo de cambio del día.");
                }
            }
        }
    }
}
