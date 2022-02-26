using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmogusOS.System;

namespace AmogusOS.System.Apps
{
    public class Neofetch
    {
        public void Exec()
        {
            Console.WriteLine($@"
                    
                  (&/,.**/(&&(               {SysInfo.username}
                 @*           (@             __________________
                @( @#,,.   ,@,.,@            
               %%   #@@@@@@&.   /%           OS: {SysInfo.OS}
               @..              .@           
              #/                 &           CPU: {SysInfo.CPU}
              @..                %*          
             //     .. .         (/          RAM: {SysInfo.RAM}
             @. . .,*/(((* .     /#          
            (%   *@       @,     *#          
       @/,*/%...  &.      @.     /#          
       @/..   ../&&   %@%%#. .   (.          
                     @,   ...  .(@           
                         ,((,                

");
        }
    }
}
