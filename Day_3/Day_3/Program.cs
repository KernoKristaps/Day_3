using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Funkcija(5,6);
            Funkcija(12,8);
            Console.ReadLine();
        }
        static void Funkcija(int skaitlis1, int skaitlis2)
        {
            int c = skaitlis1 + skaitlis2;
            Console.WriteLine(c);
        }
    }
}
