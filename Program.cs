using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using Console = Colorful.Console;
using System.Drawing;
using Colorful;

namespace losulosu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Losowanie na pytanko - WĘGIEL STUDIO";

            uint twojnumer = 0;
            uint stillalives = 0;
            uint zgony = 0;

            Console.WriteLine("Podaj swój piękny numerek z dziennika", Color.Crimson);
            twojnumer = uint.Parse(Console.ReadLine());

            Console.WriteLine("Podaj ilosc czynników wpływających na to jak bardzo masz przesrane (np 10)", Color.Crimson);
            
            int iloscczynnikow = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczby które będą uwzględnione do potężnych obliczeń,", Color.Crimson);
            Console.WriteLine("(jak dales wczesniej 10 to daj 10 liczb np: 11 9 2020 13 56 23 43 81 29 69 )", Color.DarkRed);

            string czynnikiwstringuuu = Console.ReadLine();

            uint[] czynniki = new uint[iloscczynnikow];

            Console.WriteLine("");
            Console.WriteLine("Daj mi chwilę albo dwie", Color.Peru);
            Console.WriteLine("");

            for (int i = 0; i < iloscczynnikow; i++)
            {                
                string[] liczs = czynnikiwstringuuu.Split(' ');
                czynniki[i] = uint.Parse(liczs[i]);
            }

            for (int i = 0; i < czynniki.Length; i++)
            {
                if(czynniki[i] == twojnumer)
                {
                    Console.WriteLine("Zgon totalny (twoj numer jest jednym z zakresu :c F) " + czynniki[i].ToString() + "==" + twojnumer.ToString(), Color.Red);
                    zgony += 100;
                }
                for (int s = 0; s < czynniki.Length; s++)
                {
                    if(czynniki[s] + czynniki[i] == twojnumer)
                    {
                        Console.WriteLine("Zgon bo: " + czynniki[s].ToString() + "+" + czynniki[i].ToString(), Color.Crimson);
                        zgony++;
                    }
                    else
                    {
                        stillalives++;
                    }

                    if(czynniki[s] > czynniki[i])
                    {
                        if(czynniki[s] - czynniki[i] == twojnumer)
                        {
                            Console.WriteLine("Zgon bo: " + czynniki[s].ToString() + "-" + czynniki[i].ToString(), Color.Crimson);
                            zgony++;
                        }
                        else
                        {
                            stillalives++;
                        }
                    }
                }
            }

            int r = 0, g = 0, b = 0;

            Console.WriteLine("");
            double ijak = (zgony / stillalives);

            if (ijak > 0.60)
            {
                r = 255;
                g = 15;
            }

            if (ijak > 0.5 && ijak < 0.60)
            {
                r = 255;
                g = 165;
            }

            if (ijak < 0.5)
            {
                g = 255;
            }

            Console.WriteLine("zgony: " + zgony + " | zycia: " + stillalives + " (wiecej = gorzej) stosunek: " + (float)zgony / stillalives + "% że to będziesz ty", Color.FromArgb(r,g,b));
            Console.ReadKey();
        }
    }
}
