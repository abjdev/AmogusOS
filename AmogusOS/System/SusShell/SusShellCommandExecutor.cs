using Cosmos.HAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmogusOS.System.SusShell
{
    public class SusShellCommandExecutor
    {
        FS fs = new FS();
        public void Time()
        {
            Console.WriteLine(RTC.Hour + ":" + RTC.Minute);
        }

        public void Date()
        {
            Console.WriteLine(RTC.DayOfTheMonth + "/" + RTC.Month + "/" + RTC.Year);
        }

        public void Neofetch()
        {
            Apps.Neofetch nf = new Apps.Neofetch();
            nf.Exec();
        }

        public void Shutdown()
        {
            Cosmos.System.Power.Shutdown();
        }
        public void Reboot()
        {
            Cosmos.System.Power.Reboot();
        }

        public void ListDir(string path)
        {
            fs.PrintAllFilesFromDirectory(path);
        }
    }
}
