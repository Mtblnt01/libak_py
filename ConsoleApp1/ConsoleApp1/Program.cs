using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Kiir(int[] t, string cim)
        {
            Console.WriteLine(cim);
            foreach (int szam in t)
            {
                Console.Write($"{szam}, ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] libak = { 1, 5, 2, 3, 4 };
            Kiir(libak, "libak sullyai" );

            Console.WriteLine("Nyomj eg billentyűt");
            Console.ReadKey();
        }
    }
}
