using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingConsole
{
    class Child // plain old c sharp object (poco) 
    {
        public string Name { get; set; }   // auto property
        public bool Sick { get; set; }

        public string ForgeASickNote() // method signature
        {
            return Sick
              ?  $"Please excuse {Name} from class today because they are very sick." // ternary if
              :  $"{Name}, you still have to go to school, quit faking. Love Mom"; // ternary else
        }
    }
}
