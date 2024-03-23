using Colored_Items.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colored_Items.Interfaces
{
    internal interface IItemColor<T>
    {
        
        T Item { get; set; }
        void PrintColorWithType(string color); 

    }
}
