using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {//övning1
            Console.Write(" Skriv in mönsterdjup: ");
            string skriv = Console.ReadLine();
            double x = double.Parse(skriv);
            if (x < 1.6)
            {
                Console.WriteLine("Olagligt däck!");
            }
            else
            {
                Console.WriteLine("Lagligt däck!");
            }

            //övning 2
            Console.Write("Mata in ålder:");
            string skriva = Console.ReadLine();
            int y = int.Parse(skriva);
            if (y <= 12)
            {
                Console.WriteLine("Vit");
            }
            if (12 < y && y <= 18)
            {
                Console.WriteLine("Grön");
            }
            if (18 < y && y <= 25)
            {
                Console.WriteLine("Röd");
            }
            if (25 < y && y <= 99)
            {
                Console.WriteLine("Blå");
            }
            if (y > 99)
            {
                Console.WriteLine("Ogiltig ålder");
            }

            //övning 3
            Console.Write("Mata in tal 1:");
            string skrivit = Console.ReadLine();
            decimal z = decimal.Parse(skrivit);
            Console.Write("Mata in tal 2:");
            string skrivit1 = Console.ReadLine();
            decimal q = decimal.Parse(skrivit1);
            if (z > q)
            {
                Console.WriteLine("Tal 1 är störst");
            }
            if (z < q)
            {
                Console.WriteLine("Tal 2 är störst");
            }
            if (z == q)
            {
                Console.WriteLine("Talen var lika");
            }


            //övning 4
            Console.Write("Mata in ett tal:");
            string talet = Console.ReadLine();
            int tal1 = int.Parse(talet);
            if ((tal1 % 7) == 0)
            {
                Console.WriteLine("Talet är Delbart med sju");
            }
            else
            {
                Console.WriteLine("Talet är ej delbart med 7");
            }
        }
    }
}