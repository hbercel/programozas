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
            int szam3 = Convert.ToInt32(Console.ReadLine());
            if (szam3 <= 0)
            {
                Console.WriteLine("Fagy van kint {0} fok", szam3);
            }
            else
            {
                Console.WriteLine("nincs fagy kint {0} fok", szam3);
            }
            //4. feladat
            Console.WriteLine("Ez a program eldönti hogy a szám 30 és 40 között van e");
            int szam4 = Convert.ToInt32(Console.ReadLine());
            if ( szam4 < 40 && szam4 > -30 )
            {
                Console.WriteLine("A {0} szám -30 és 40 között van", szam4);
            }
            else
            {
                Console.WriteLine("A {0} szám nincsen -30 és 40 között", szam4);
            }
            //5. feladat
            Console.WriteLine("Ez a program megszoroza 10-el a 16 nál kissebb számokat és elosztja hárommal a 16 nál nagyobbakat ");
            int szam5 = Convert.ToInt32(Console.ReadLine());
            if (szam5 < 16)
             {
                 Console.WriteLine("A {0} szám kisseb mint 16 {1}",szam5, szam5*10);
             }
             else
             {
                Console.WriteLine("A {0} szám kissebb mint 16 {1} ", szam5,szam5 % 3);
             }
             Console.ReadLine();
            //12. feladat
            Console.WriteLine("Ez a program eldönti egy számról hogy melyik hónap");
            int szam6 = Convert.ToInt32(Console.ReadLine());
            switch (szam6)
            {
                case 1:
                    Console.WriteLine("Január");
                    
                    break;
                case 2:
                    Console.WriteLine("Február");

                    break;
                case 3:
                    Console.WriteLine("Március");

                    break;
                case 4:
                    Console.WriteLine("Április");

                    break;
                case 5:
                    Console.WriteLine("Május");

                    break;
                case 6:
                    Console.WriteLine("Június");

                    break;
                case 7:
                    Console.WriteLine("Julis");

                    break;
                case 8:
                    Console.WriteLine("Augusztus");

                    break;
                case 9:
                    Console.WriteLine("Szeptember");

                    break;
                case 10:
                    Console.WriteLine("Október");

                    break;
                case 11:
                    Console.WriteLine("November");

                    break;
                case 12:
                    Console.WriteLine("December");

                    break;

                default:
                    Console.WriteLine("Nem hónap szám");
                    break;


            }
            //13. feladat
            Console.WriteLine("Ez a program eldönti egy számról hogy melyik évszak");
            int szam7 = Convert.ToInt32(Console.ReadLine());
            switch (szam7)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Tél");
                     
                  break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Tavasz");

                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Nyár");

                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Ősz");

                    break;

                default:
                    Console.WriteLine("Nem évszak szám");
                    break;
            }
            //14. feladat
            /*Console.WriteLine("Ez a program eldönti egy számról hogy hány jegyű");
            int szam8 = Convert.ToInt32(Console.ReadLine());
            switch (szam8)
            {
                case 1 - 10:
                    Console.WriteLine("A szám egyjegyű");
                  break;
            }*/
            Console.ReadLine();



        }
    }
}
