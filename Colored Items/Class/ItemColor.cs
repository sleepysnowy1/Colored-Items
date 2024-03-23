using Colored_Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colored_Items.Class
{
    internal class ItemColor<T> : IItemColor<T>
    {

        public T Item { get; set; }

        public ItemColor(T item)
        {
            this.Item = item;

        }
        public void PrintColorWithType(string color)
        {
            

            if (color == "red" || color == "Red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == "blue" || color == "Blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (color == "green" || color == "Green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine(color + " " + Item.ToString());
            Console.ForegroundColor = ConsoleColor.White;
            
        }
    }
}
