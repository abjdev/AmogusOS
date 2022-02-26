using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommanderLibraries_v1;

namespace AmogusOS.System
{
    public class Login
    {
        public void RunLogin()
        {
            var password = File.ReadAllText("0:\\AmogusOs\\password.db"); //this will get the password
            var username = File.ReadAllText("0:\\AmogusOs\\users.db"); //this will show the username

            Console.Write("Password as " + username + ":");
            var iPassword = TextFormatting.PasswordMask('*');

            if (iPassword == password)
            {
                SusShell.SusShell ss = new SusShell.SusShell();
                ss.DrawTerminal();
            }
            else
            {
                Console.WriteLine("Username or password is invalid.");
            }
        }
    }
}
