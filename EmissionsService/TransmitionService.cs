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
using AutoMapper;

namespace EmissionsService
{
    class TransmitionService
    {
        public static void SendData(List<TransferData> transmissionDataList)
        {
            var service = new WebServiceReference.EmissionsWebServiceSoapClient();
            var transmitionDataMapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TransferData, WebServiceReference.TransferData>();
            }).CreateMapper();

            var transmissionDataArray = new WebServiceReference.TransferData[transmissionDataList.Count()];

            for (int i = 0; i < transmissionDataList.Count(); i++)
            {
                transmissionDataArray[i] = transmitionDataMapper.Map<WebServiceReference.TransferData>(transmissionDataList[i]);
            }

            string result;
            Console.WriteLine(transmissionDataList[0].value);
            Console.WriteLine(transmissionDataArray[0].value);

            try
            {
                result = service.TestMethod(transmissionDataArray);
            }
            catch
            {
                result = "Some error";
            }

            Console.WriteLine(result);
        }
    }
}
