using Newtonsoft.Json;
using PesalinkLiveTester.TranscationClasses;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesalinkLiveTester
{
    class Program
    {
       
        static void Main(string[] args)
        {
           var response = CreditTransfer();
        }
        public static string CreditTransfer()
        {
            string Response = null;

            var commanddata = new Credit_CreditTransfer()
            {
                OriginalmessageId = "",
                DebtorPhonNb = "",
                CdtrBankCode = "",
                DbtrName = "",
                DbtrAcct = "",
                DbtrAcctName = "",
                amount = "",
                EndtoEndId = ""

            };
            var Body = JsonConvert.SerializeObject(commanddata);

            var client = new RestClient("");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            var body = Body;
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            Response = response.Content;
            return Response;
        }
        public static string AccountVerification()
        {
            string Response = null;

            var commanddata = new AccountVerification()
            {
               AccountNo ="",
               BackCode =""

            };
            var Body = JsonConvert.SerializeObject(commanddata);

            var client = new RestClient("");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            var body = Body;
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            Response = response.Content;
            return Response;
        }
        public static string PaymentStatus()
        {
            string Response = null;

            var commanddata = new PaymentStatus()
            {
                OriginalmessageId = "",
                DebtorPhonNb = "",
                CdtrBankCode = "",
                DbtrName = "",
                DbtrAcct = "",
                DbtrAcctName = "",
                amount = "",
                EndtoEndId = ""

            };
            var Body = JsonConvert.SerializeObject(commanddata);

            var client = new RestClient("");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            var body = Body;
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            Response = response.Content;
            return Response;
        }
    }
}
