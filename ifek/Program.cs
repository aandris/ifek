using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float szam;
            Console.WriteLine("Adj meg egy számot: ");
            szam = Convert.ToInt32(Console.ReadLine());

            if (szam % 2 == 0)
            {
                Console.WriteLine("Ez a szám páros");
            }

            else
            {

                Console.WriteLine("Ez a szám páratlan");

            }

        }
    }
}
