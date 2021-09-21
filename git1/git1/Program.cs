using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            Console.WriteLine("Ez a program eldönti hogy a szám páros vagy páratlan");
            double szam = Convert.ToDouble(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("A {0} szám páros", szam);
            }
            else
            {
                Console.WriteLine("A {0} szám páratlan",szam);
            }
            //2. feladat
            Console.WriteLine("Ez a program eldönti hogy a szám negatív vagy pozitív");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            if (szam2 >= 0)
            {
                Console.WriteLine("A {0} szám pozitív",szam2);
            }
            else
            {
                Console.WriteLine("A {0} szám negatív", szam2);
            }
            //3. feladat
            Console.WriteLine("Ez a program eldönti hogy fagy van e kint vagy nem");
            Console.ReadLine();
            if (szam2 <= 0)
            {
                Console.WriteLine("Fagy van kint {0} fok", szam2);
            }
            else
            {
                Console.WriteLine("nincs fagy kint {0} fok", szam2);
            }
            //4. feladat
            Console.WriteLine("Ez a program eldönti hogy a szám 30 és 40 között van e");
            Console.ReadLine();
            if ( szam2 < 40 && szam2 > 30 )
            {
                Console.WriteLine("A {0} szám 30 és 40 között van", szam2);
            }
            else
            {
                Console.WriteLine("A {0} szám nincsen 30 és 40 között", szam2);
            }
            Console.ReadLine();
            if (szam2 < 16)
            {
                Console.WriteLine("A szám kisseb mint 16 {}", szam2*10);
            }
            else
            {
                Console.WriteLine("A {0} szám nincsen 30 és 40 között", szam2);
            }
            Console.ReadLine();


        }
    }
}
