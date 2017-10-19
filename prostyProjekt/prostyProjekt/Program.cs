using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prostyProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,wynik;
            Console.WriteLine("Podaj a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            c = Int32.Parse(Console.ReadLine());
            wynik = a * b * c;

            Console.WriteLine(wynik);
            Console.ReadKey();
        }
        
    }
}
