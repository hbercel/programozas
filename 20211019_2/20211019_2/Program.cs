using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211019_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            feladat5();
        }
        static void feladat1()
        {
            Console.WriteLine("Kérem a téglalap oldalát");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("A téglalap térfogata{0} és a felszíne{1}",a*b*c,2*(a*b+a*b+b*c));
            Console.ReadLine();
        }
        static void feladat2()
        {
            Console.WriteLine("Kérek egy számot egy és hét között");
            int szam = int.Parse(Console.ReadLine());
            switch (szam)
            {
                case 1:
                    Console.WriteLine("hétfő");
                    break;
                case 2:
                    Console.WriteLine("Kedd");
                    break;
                case 3:
                    Console.WriteLine("Szerda");
                    break;
                case 4:
                    Console.WriteLine("Csütörtök");
                    break;
                case 5:
                    Console.WriteLine("Péntek");
                    break;
                case 6:
                    Console.WriteLine("Szombat");
                    break;
                case 7:
                    Console.WriteLine("Vasárnap");
                    break;

                default:
                    Console.WriteLine("nem jó szám");
                    break;
                    
                    


            }
            Console.ReadLine();
        }
        static void feladat3()
        {
            Console.WriteLine("Kérek egy számot");
            double szam = double.Parse(Console.ReadLine());
            if (szam > -50 && 70 > szam)
            {
                Console.WriteLine("Benne van");
            }
            else
            {
                Console.WriteLine("Nincs benne");
            }
            Console.ReadLine();

        }
        static void feladat4()
        {
            for (int i = 120; i >= 39; i=i-15)
            {
                Console.WriteLine("{0}",i);
            }
            Console.ReadLine();
        }
        static void feladat5()
        {
            for (int i = 1; i < 40; i++)
            {
                if(i*9%7==0)
                {
                    Console.WriteLine("{0}",i*9);
                }

            }
            Console.WriteLine();
            int cv = 1;
            while (cv < 41)
            {
                if (cv * 9 % 7 == 0)
                {
                    Console.WriteLine("{0}",cv*9);
                }
                cv++;
            }
            Console.ReadLine();
        }
    }
}
