<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.IO;
using System.Drawing;
using Cosmos.Core;
using AmogusOS.System;
using AmogusOS.System.Converting;

namespace AmogusOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            FS fs = new FS();
            fs.InitFS();
            Setup stp = new Setup();
            stp.CheckForInstalled();
        }

        protected override void Run()
        {

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.IO;
using System.Drawing;
using Cosmos.Core;
using AmogusOS.System;
using AmogusOS.System.Converting;

namespace AmogusOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            FS fs = new FS();
            fs.InitFS();
            Setup stp = new Setup();
            stp.CheckForInstalled();
        }

        protected override void Run()
        {

        }
    }
}
>>>>>>> 94899b1 (Adding initial files.)
