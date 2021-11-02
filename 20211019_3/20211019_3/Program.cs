using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211019_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // feladat1();
            feladat2();
            //feladat3();
            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void feladat1()
        {
            
            try
            {
                Console.WriteLine("Kérek egy egész számot");
                int szam = int.Parse(Console.ReadLine());
                int db = 0; //db - osztók száma
                for (int i = 1; i <= szam; i++)
                {
                    if (szam%i==0)
                    {
                        db++;
                    }
                }
                Console.WriteLine("A {0} számnak {1} osztója van",szam,db);

            }
            catch(Exception)
            {
                Console.WriteLine("Nem jó értéket adtál");
            }

        }
        static void feladat2()
        {
            int db = 0;
            double[] homerseklet = new double[7];
            Random rnd = new Random();
            for (int i = 0; i < homerseklet.Length; i++)
            {
                homerseklet[i] = rnd.Next(120, 181) / 10;
                Console.WriteLine("{0} ",homerseklet[i]);

                if (homerseklet[i] > 15)
                {
                    db++;
                }
            }
            Console.WriteLine("{0} 15 foknál melegebb nap volt",db);
           
        }
        static void feladat3()
        {
            int[] auto = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < auto.Length; i++)
            {
                auto[i]
            }
        }
    }
}
