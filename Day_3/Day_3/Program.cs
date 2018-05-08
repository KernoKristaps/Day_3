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
            int mainigais = Funkcija2(10,12);
            Console.WriteLine(mainigais);
            Console.ReadLine();
            
            string ir = Funkcija3("divi","plus","divi");
            Console.WriteLine(ir);


            Console.ReadLine();
        }
        static void Funkcija(int skaitlis1, int skaitlis2)
        {
            int x = skaitlis1 + skaitlis2;
            Console.WriteLine(x);
        }
        static int Funkcija2(int a, int b)
        {
            int c;
            c = a + b;
            return c;
        }
        static string Funkcija3(string a1,string b2, string c3)
        {
            string ir;
            ir = a1 + b2 + c3;

            return ir;
        }
    }
}
