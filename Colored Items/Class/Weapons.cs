using Colored_Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colored_Items.Class
{
    internal class Weapons 
    {
        
        
        public class Sword : Weapons
        {
            public override string ToString()
            {
                return "Sword";
            }

        }
        public class  Axe : Weapons
        {
            public override string ToString()
            {
                return "Axe";
            }
        }

        public class  Bow : Weapons
        {
            public override string ToString()
            {
                return "Bow";
            }
        }
        
            
        
    }
}
