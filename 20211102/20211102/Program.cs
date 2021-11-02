using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211102
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            feladat3();

            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void feladat1()
        {
            /* Olvass be pár számot (ha kell, a darabszámot is kérje be
             * a program), majd írd ki a páratlanok számát! */
            // Random rnd = new Random();

            try
            {
                Console.Write("Add meg az elemek számát! ");
                int elemszam = int.Parse(Console.ReadLine());
                // tömbbel:
                int[] szamok = new int[elemszam];
                for (int i = 0; i < szamok.Length; i++)
                {
                    szamok[i] = rnd.Next(0, 100);
                }
                Console.WriteLine();
                int db_paratlan = 0;
                int[] paratlan = new int[elemszam];
                int j = 0;
                for (int i = 0; i < szamok.Length; i++)
                {
                    if (szamok[i] % 2 == 1)
                    {
                        db_paratlan++;
                        paratlan[j] = szamok[i];
                        j++;
                    }
                }
                Console.WriteLine("A páratlanok száma {0}", db_paratlan);
                Console.WriteLine("A páratlanok összege {0}", paratlan.Sum());
                Console.WriteLine("A páratlanok átlaga {0}",paratlan.Average());
                Console.WriteLine("A legkissebb páratlan {0}", paratlan.Min());
                Console.WriteLine("A Legnagyobb páratlan {0}", paratlan.Max());
                //sorbarendezés
                Array.Sort(paratlan);
                foreach (var item in paratlan)
                {
                    Console.WriteLine("{0}",item);
                }
                Console.WriteLine();
                //fordított sorrendbe
                Array.Reverse(paratlan);
                foreach (var item in paratlan)
                {
                    Console.WriteLine("{0}", item);
                }
                Console.WriteLine();

                //listával
                List<int> veletlenek = new List<int>();
                List<int> prl = new List<int>();
                for (int i = 0; i < elemszam; i++)
                {
                    veletlenek.Add(rnd.Next(0, 100));
                    Console.WriteLine("{0}",veletlenek[i]);
                }
                Console.WriteLine();
                int db_prl = 0;
                foreach (var item in veletlenek)
                {
                    if (item % 2 == 1)
                    {
                        db_prl++;
                        prl.Add(item);
                    }

                }
                Console.WriteLine("A páratlanok száma {0}",db_prl);
                Console.WriteLine("A páratlanok száma {0}", prl.Count);
                Console.WriteLine("A páratlanok összege {0}", prl.Sum());
                Console.WriteLine("A páratlanok átlaga {0}", prl.Average());
                Console.WriteLine("A legkissebb páratlan {0}", prl.Min());
                Console.WriteLine("A Legnagyobb páratlan {0}", prl.Max());
                prl.Sort();
                foreach (var item in prl)
                {
                    Console.WriteLine("{0}",item);

                }
                Console.WriteLine();
                prl.Reverse();
                foreach (var item in prl)
                {
                    Console.WriteLine("{0}", item);

                }
                Console.WriteLine();

            }
            catch (Exception)
            {

                Console.WriteLine("Nem jó adatot adtál");
            }

        }
        static void feladat2()
        {
            try
            {
                Console.Write("Add meg az elemek számát! ");
                int elemszam = int.Parse(Console.ReadLine());
                // tömbbel:
                int[] szamok = new int[elemszam];
                for (int i = 0; i < szamok.Length; i++)
                {
                    szamok[i] = rnd.Next(0, 100);
                }
                Console.WriteLine();
                int db_paros = 0;
                int[] paros = new int[elemszam];
                int j = 0;
                for (int i = 0; i < szamok.Length; i++)
                {
                    if (szamok[i] % 2 == 1)
                    {
                        db_paros++;
                        paros[j] = szamok[i];
                        j++;
                    }
                }
                Console.WriteLine("A párosok száma {0}", db_paros);
                Console.WriteLine("A párosok összege {0}", paros.Sum());

            }
            catch (Exception)
            {
                Console.WriteLine("Nem jó adatot adtál");
            }
        }
        static void feladat3()
        {
            try
            {
                Console.WriteLine("Add meg az elemek számát!");
                int elemszam = int.Parse(Console.ReadLine());
                int[] szamok = new int[elemszam];
                for (int i = 0; i < szamok.Length; i++)
                {
                    szamok[i] = rnd.Next(0, 100);//😂👀👀🤢🤢🤢🤢
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Nem jó adatot adtál");
            }
        }
    }
}

    

