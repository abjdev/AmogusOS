using AmogusOS.System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;
namespace AmogusOS
{
    public class Setup
    {
        FS fs = new FS();
        public void InstallAmogusOS()
        {
            Console.Clear();
            Console.WriteLine("AmogusOs will be install in your pc");
            Console.WriteLine("Create a username and password:");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string cPassword = Console.ReadLine();
            //Console.Write(username + "> "); //when your put username variable it should look like this "The user name: "
            Console.WriteLine("Creating System Directory..."); //Creating Directory or folder
            fs.CreateDirectory("0:\\AmogusOs\\");
            Console.WriteLine("Creating File for user");
            fs.CreateFile("0:\\AmogusOs\\System.txt"); //Creating File System
            fs.CreateFile("0:\\AmogusOs\\users.db");
            fs.CreateFile("0:\\AmogusOs\\password.db"); //creating a password files
            Console.WriteLine("Setting User Preferences...");
            File.WriteAllText("0:\\AmogusOs\\System.txt", "DONT EDIT OR FBI OPENS YOUR DOOR");
            File.WriteAllText("0:\\AmogusOs\\users.db", username); //This will save username
            File.WriteAllText("0:\\AmogusOs\\password.db", cPassword); //this one will save the user password
            Console.WriteLine("Setup Finished! Press any key to reboot.");
            Console.ReadKey();
            Sys.Power.Reboot(); //when the installation done it will reboot`
        }

        public void CheckForInstalled()
        {
            if (!File.Exists("0:\\AmogusOs\\System.txt"))
            {
                InstallAmogusOS();
            }
            else
            {
                Login login = new Login();
                login.RunLogin();
            }
        }
    }
}
