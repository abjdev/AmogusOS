using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmogusOS.System.SusShell
{
    public class SusShell
    {
        SusShellCommandExecutor executor = new SusShellCommandExecutor();
        public void DrawTerminal()
        {
            var username = File.ReadAllText("0:\\AmogusOs\\users.db"); //this will show the username
            while (true)
            {
                Console.Write(username + " ->");
                var input = Console.ReadLine();
                // Check command
                if (input == "time")
                {
                    executor.Time();
                }
                else if (input == "date")
                {
                    executor.Date();
                }
                else if (input == "shutdown")
                {
                    executor.Shutdown();
                }
                else if (input == "reboot")
                {
                    executor.Reboot();
                }
                else if (input == "neofetch")
                {
                    executor.Neofetch();
                }
                else if (input == "ls")
                {
                    executor.ListDir(@"0:\");
                }
                else
                {
                    Console.WriteLine("SussyShell: " + input + " command not found.");
                }
            }
        }
    }
}
