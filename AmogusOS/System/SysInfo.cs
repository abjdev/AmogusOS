using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System;


namespace AmogusOS.System
{
    public static class SysInfo
    {
        public static string CPU = Cosmos.Core.CPU.GetCPUBrandString();
        public static uint RAM = Cosmos.Core.CPU.GetAmountOfRAM();
        public static string OS = "AmogusOS 0.0.1";
        public static string username = File.ReadAllText("0:\\AmogusOs\\users.db");

    }
}
