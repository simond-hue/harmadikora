﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmadikOra
{
    class Program
    {
        static double[] Input(int darabszam)
        {
            string input = "";
            Console.Write("Adjon meg az előbb megadott darbmennyiségű számot (space-ekkel elválasztva): ");
            input = Console.ReadLine();
            string[] inputSplit = input.Split(' ');
            double[] tomb = new double[darabszam];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = Convert.ToDouble(inputSplit[i]);
            }
            return tomb;
        }

        static double Max(double[] tomb)
        {
            double max = tomb[0];
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
            }
            return max;
        }

        static double Min(double[] tomb)
        {
            double min = tomb[0];

            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
            }

            return min;
        }

        static void Main(string[] args) 
        {
            try
            {
                Console.Write("Adja meg az elemszámot: ");
                int darabszam = Convert.ToInt32(Console.ReadLine());
                double[] tomb = Input(darabszam);
                Console.WriteLine("A legnagyobb elem: " + Max(tomb));
                Console.WriteLine("A legkisebb elem: " + Min(tomb));
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Bemeneti hiba!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba!");
                Console.ReadKey();
            }
        }
    }
}
