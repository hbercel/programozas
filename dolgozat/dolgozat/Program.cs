using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                //feladat.1
                Console.WriteLine("Kérek egy téglatest három élének hosszát és megmondom a térfogatot és a felszínt");
                int szamoa = Convert.ToInt32(Console.ReadLine());
                int szamob = Convert.ToInt32(Console.ReadLine());
                int szamoc = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("A téglatest felszine {0} ",2*(szamoa*szamob+szamoa*szamoc+szamob*szamoc));
                Console.WriteLine("A téglatest térfogata {0}",szamoa*szamob*szamoc);
                Console.ReadLine();
                
                //feladat.2
               /*int szam2 = Convert.ToInt32(Console.ReadLine());
               switch (szam2)
               {
                    case 1:
                        Console.WriteLine("Hétfő");
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





                }
                Console.ReadLine();*/
                //feladat.3
                /*int szam2 = Convert.ToInt32(Console.ReadLine());
                if (szam3 > -50 && szam3 < 70)
                {
                    Console.WriteLine("A {0} szám -50 és 70 között van", szam3);
                }
                else
                {
                    Console.WriteLine("A {0} szám nincs -50 és 70 között",szam3);
                }
                Console.ReadLine();*/
                //feladat.4
                /*for (int i = 40; i < 120; i= i+15)
                {
                    Console.WriteLine("{0}",i );
                }
                Console.ReadLine();*/



            }
        }
    }
}
