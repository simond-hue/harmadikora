using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmadikOra
{
    class Program
    {
        static void Main(string[] args) 
        {
            string input = "";
            Console.Write("Adjon meg 10 számot (space-ekkel elválasztva): ");
            input = Console.ReadLine();
            string[] inputSplit = input.Split(' ');
            int[] tomb = new int[10];
            for(int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = Convert.ToInt32(inputSplit[i]);
            }

            int max = tomb[0];

            for(int i = 1; i < tomb.Length; i++)
            {
                if(tomb[i] > max)
                {
                    max = tomb[i];
                }
            }

            Console.WriteLine("A legnagyobb elem: " + max);
            Console.ReadKey();
        }
    }
}
