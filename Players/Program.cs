using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    internal class Program
    {
        public static void Main() 
        {
            Hero hero = new Hero("diana", 300);
            Elf elf = new Elf("petko", 100);
            BladeKnight bladeKnight = new BladeKnight ("pesho", 100);

            Console.WriteLine(hero);
            Console.WriteLine(elf);
            Console.WriteLine(bladeKnight);
        }
    }
}
