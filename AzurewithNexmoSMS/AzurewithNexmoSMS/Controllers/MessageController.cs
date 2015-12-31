using AzurewithNexmoSMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AzurewithNexmoSMS.Controllers
{
    public class MessageController : ApiController
    {
        public string SendMessage([CustomSummary("Nexmo Key")]string apikey, [CustomSummary("Nexmo Secret")] string apiSecret, [CustomSummary("Recipient number")] string to, [CustomSummary("Message text")] string text, [CustomSummary("Enable SMS")] bool enable = true)
        {
            try
            {
                if (enable)
                {
                    SmsSender s = new SmsSender();
                    string from = s.GetAccountNumber(apikey, apiSecret);
                    s.SendSMS(to, from, apikey, apiSecret, Uri.EscapeUriString(text));
                }
                else
                    return "disabled";
            }
            catch
            {
                return "fail";
            }
            return "success";
        }
    }
}
