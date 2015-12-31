using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml;
namespace AzurewithNexmoSMS.Models
{
    public class SmsSender
    {
        public string SendSMS(string number, string from, string username, string pasword, string text)
        {
            string uri = string.Format("https://rest.nexmo.com/sms/json?api_key={0}&api_secret={1}&from={2}&to={3}&text={4}", username, pasword, from, number, text);
            var json = new WebClient().DownloadString(uri);
            return json;
        }

        private SmsResponse ParseSmsResponseJson(string json)
        {
            // hyphens are not allowed in in .NET var names
            json = json.Replace("message-count", "MessageCount");
            json = json.Replace("message-price", "MessagePrice");
            json = json.Replace("message-id", "MessageId");
            json = json.Replace("remaining-balance", "RemainingBalance");
            return new JavaScriptSerializer().Deserialize<SmsResponse>(json);
        }

        public string GetAccountNumber(string username, string password)
        {
            string FromNumber = string.Empty;
            string uri = string.Format("https://rest.nexmo.com/account/numbers/{0}/{1}", username, password);
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Method = "GET";
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            string result = string.Empty;
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                result = reader.ReadToEnd();
            }
            var jss = new JavaScriptSerializer();
            var dict = jss.Deserialize<RootObject>(result);
            if (dict.numbers.Count > 0)
            {
                FromNumber = dict.numbers[0].msisdn;
            }
            return FromNumber;
        }



        public string ListVM()
        {
            HttpWebRequest request = WebRequest.Create(new Uri("https://management.core.windows.net/f6ae0e8d-9339-48d1-a65e-ff5ffa54bc4a/services/hostedservices")) as HttpWebRequest;
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Method = "GET";

            X509Store certificateStore = null;
            X509Certificate2 certificate = null;
            try
            {
                certificateStore = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                certificateStore.Open(OpenFlags.ReadOnly);
                string thumbprint = "8F8CB48229595D08A3E59470E3815775E1ACB258";// ConfigurationManager.AppSettings["CertThumbprint"];
                var certificates = certificateStore.Certificates.Find(X509FindType.FindByThumbprint, thumbprint, false);
                if (certificates.Count > 0)
                {
                    certificate = certificates[0];
                }
            }
            finally
            {
                if (certificateStore != null) certificateStore.Close();
            }

            request.Headers.Add("x-ms-version", "2014-04-01");
            request.ClientCertificates.Add(certificate);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            string result = string.Empty;
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                result = reader.ReadToEnd();
            }


            XmlDocument doc = new XmlDocument();
            doc.LoadXml(result);
            XmlNode node = (XmlNode)doc.DocumentElement;

            string serviceNames = "";
            foreach (XmlNode n in node.ChildNodes)
            {
                serviceNames += n.ChildNodes[1].InnerText + " ";
            }

            return serviceNames;
        }
    }

    public class Message
    {
        public string To { get; set; }
        public string Messageprice { get; set; }
        public string Status { get; set; }
        public string MessageId { get; set; }
        public string RemainingBalance { get; set; }
    }

    public class SmsResponse
    {
        public string Messagecount { get; set; }
        public List<Message> Messages { get; set; }
    }

    public class Number
    {
        public string country { get; set; }
        public string msisdn { get; set; }
        public string type { get; set; }
        public List<string> features { get; set; }
    }

    public class RootObject
    {
        public int count { get; set; }
        public List<Number> numbers { get; set; }
    }
}