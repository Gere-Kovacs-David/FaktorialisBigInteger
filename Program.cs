using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//biginteger osztály elérése -> references -> add referenc sys numrics

namespace FaktoriálisBigInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktoriális meghatározása 20-40 között");
            for (int szám = 20; szám <= 40; szám++)
            {
                BigInteger faktor = 1;
                for (int i = 2; i <= szám ; i++)
                {
                    faktor = faktor * i;
                }
                Console.WriteLine($"{szám} != {faktor}");
            }
            Console.ReadKey();
            Console.WriteLine("ja");
        }
}
