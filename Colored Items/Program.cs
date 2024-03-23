using Colored_Items.Class;
using Colored_Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colored_Items
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ItemColor<Weapons.Sword> sword = new ItemColor<Weapons.Sword>(new Weapons.Sword());

            ItemColor<Weapons.Axe> axe = new ItemColor<Weapons.Axe>(new Weapons.Axe());

            ItemColor<Weapons.Bow> bow = new ItemColor<Weapons.Bow>(new Weapons.Bow());

            sword.PrintColorWithType("Red");
            axe.PrintColorWithType("Green");
            bow.PrintColorWithType("Blue"); 
        }
    }
}
