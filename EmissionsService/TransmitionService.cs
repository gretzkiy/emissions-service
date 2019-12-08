using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Configuration;
using EmissionsLibrary;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace EmissionsService
{
    class TransmitionService
    {
        public static void SendData(List<TransferData> transmissionDataList)
        {
            string serializedTransmitionData = TransferData.Serialize(transmissionDataList);

            string soapString = @"<?xml version=""1.0"" encoding=""utf-8""?>
            <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                <soap:Body>
                    <SendData xmlns=""http://tempuri.org/"">" + $"{serializedTransmitionData}" + @"</SendData>  
                </soap:Body>
            </soap:Envelope>";

            using (var httpClient = new HttpClient())
            {
                var httpContent = new StringContent(soapString, Encoding.UTF8, "text/xml");
                httpContent.Headers.Add("SOAPAction", "http://tempuri.org/SendData");

                httpClient.PostAsync("http://localhost:3333/EmissionsClient.asmx/?op=SendData", httpContent);
            }

            Console.WriteLine(soapString);
        }
    }
}
