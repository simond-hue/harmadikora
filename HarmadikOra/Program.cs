using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmadikOra
{
    class Program
    {
        static int[] Input(int darabszam)
        {
            string input = "";
            Console.Write("Adjon meg az előbb megadott darbmennyiségű számot (space-ekkel elválasztva): ");
            input = Console.ReadLine();
            string[] inputSplit = input.Split(' ');
            int[] tomb = new int[darabszam];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = Convert.ToInt32(inputSplit[i]);
            }
            return tomb;
        }

        static int Max(int[] tomb)
        {
            int max = tomb[0];
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
            }
            return max;
        }

        static int Min(int[] tomb)
        {
            int min = tomb[0];

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
            Console.Write("Adja meg az elemszámot: ");
            int darabszam = Convert.ToInt32(Console.ReadLine());

            var tomb = Input(darabszam);

            Console.WriteLine("A legnagyobb elem: " + Max(tomb));
            Console.WriteLine("A legkisebb elem: " + Min(tomb));
            Console.ReadKey();
        }
    }
}
