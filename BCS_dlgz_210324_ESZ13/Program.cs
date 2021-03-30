using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS_dlgz_210324_ESZ13
{
    class Program
    {

        static Random rnd = new Random();
        static void Main(string[] args)
        {

            Feladat_megoldas();



            Console.ReadKey();
        }

        private static void Feladat_megoldas()
        {
            //Hozzon létre egy 100 elemű tömböt!
            int[] tomb = new int[100];

            int db = 0;

            while (db < 100)
            {

                int x = rnd.Next(1000, 10000);

                //Töltse fel 5-el osztható, 4 számjegyű véletlenszámokkal!

                if (x % 5 == 0)
                {


                    tomb[db] = x;


                    // Console.WriteLine(tomb[db]);
                    db++;

                }
            }

            //Írja ki a tömb elemeit úgy, hogy kiírásnál egy sorban pontosan 10 elem
            // szerepeljen!

            for (int i = 0; i < tomb.Length; i++)

                if ((i + 1) % 10 != 0)
                {
                    // Console.Write($"{ tomb[i]}   ");

                }

                else
                {
                    // Console.WriteLine($"{ tomb[i]}   ");
                }





            //Kiírásnál minden 7. elem színe legyen világoszöld!


            for (int i = 0; i < tomb.Length; i++)

                if ((i + 1) % 10 == 0)
                {


                    if ((i + 1) % 7 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{ tomb[i]}   ");
                        Console.ResetColor();

                    }

                    else
                    {
                        Console.WriteLine($"{ tomb[i]}   ");
                    }

                }

                else
                {
                    if ((i + 1) % 7 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{ tomb[i]}   ");
                        Console.ResetColor();

                    }

                    else
                    {
                        Console.Write($"{ tomb[i]}   ");
                    }
                }
            //Határozza meg a tömb elemeinek összegét!
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            Console.WriteLine();
            Console.WriteLine("A tömben tárolt összegek száma: {0}", osszeg);
            //Console.WriteLine(  tomb.Sum());

            Console.WriteLine();
            // Határozza a 4000-nél nem kisebb, de 5000-nél kisebb elemek átlagát!

            int atlagOsszeg = 0;
            int oszto = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] >= 4000 && tomb[i] < 5000)
                {
                    atlagOsszeg += tomb[i];
                    oszto++;
                }
            }
            int atlag = atlagOsszeg / oszto;

            Console.WriteLine($"Az  elemek átlaga: { atlag}");

            // Határozza meg, hogy szerepel-e a tömbben 65 valamelyik többszöröse! ha igen,
            // írjuk ki az első ilyen számot és az indexét is !
            Console.WriteLine();
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 65 == 0)
                {
                    Console.WriteLine($"{tomb[i]} a tömb  első száma, amely a 65 többszöröse: " +
                        $"  index értéke: {i}");
                    break;
                }
            }
            //Határozza meg, hány db 3-as számmal kezdődő szám van a tömbben!
            Console.WriteLine();
            int harmassalKezd = 0;
            for (int i = 0; i < tomb.Length; i++)
            {

                if (tomb[i] >= 3000 && tomb[i] < 4000)
                {
                    harmassalKezd++;
                }
            }
            Console.WriteLine($"{harmassalKezd} db  3-as számmal kezdődő szám van.");
            Console.WriteLine();

            // Írja ki a tömbnek az első olyan elemének indexét, amelyet elfogadható
            //forintban értelmezett órabérnek gondol egy junior szoftverfejlesztő számára!        



            int ber = 0;
            int maxi_i = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > ber)

                {
                    ber = tomb[i];
                    maxi_i = i;
                    //Console.WriteLine("Az órabér  elem indexe  {0}", maxi_i);

                }

            }
            Console.WriteLine("Az órabér  elem indexe  {0}", maxi_i);
            //Console.WriteLine(ber);
            //Console.WriteLine("-------------");
           // Console.WriteLine("maxindex: " + Array.IndexOf(tomb, tomb.Max()));



            //Válogassa ki a kerek 100-asokat a tömbből egy másik tömbb
            int[] masikTomb = new int[tomb.Length];
            int j = 0;
            Console.Write("\n100 osztható generált számok:  ");

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 100 == 0)
                {
                    masikTomb[j] = tomb[i];
                    Console.Write(masikTomb[j] + "  ");

                    j++;

                }
            }
            Console.WriteLine("\n");

            // Kerekítse a születési évedet a magyar forint kerekítési szabályainak
            // megfelelően „5 - el osztható” számmá! Határozza meg, hogy szerepel - e ez a
            //szám a tömbben!

              


            int b = 0;
            int szulEv = 1970;

            while (b < tomb.Length && tomb[b] != szulEv)
            {
                b++;
            }
            if (b < tomb.Length)
            {
                
                Console.Write($"{szulEv}   születési év  {b} x  van a tömben.");
            }
            else
            {
                Console.Write($"{szulEv} születési év  nem szerepel a tömben.");
            }


        }





    }

	

	}

        
    
