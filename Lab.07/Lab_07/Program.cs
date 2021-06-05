using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Lab_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction F1 = new Fraction(100, 77);
            Fraction F2 = new Fraction(33, 56);
            Fraction Res = new Fraction();
            Res = F1 + F2;
            Console.WriteLine("=================================\n");
            Console.WriteLine($"Result: {Res}");
            Res = F1 - F2;
            Console.WriteLine("=================================\n");
            Console.WriteLine($"Result: {Res}");
            Res = F1 * F2;
            Console.WriteLine("=================================\n");
            Console.WriteLine($"Result: {Res}");
            Res = F1 / F2;
            Console.WriteLine("=================================\n");
            Console.WriteLine($"Result: {Res}");
      
            Console.WriteLine("=================================\n");
            Console.WriteLine($"Result: {F1 > F2}");

            Console.WriteLine("=================================\n");
            Console.WriteLine($"Result: {F1 < F2}");

            Console.WriteLine("=================================\n");
            Console.WriteLine($"Result: {F1 == F2}");

            Console.WriteLine("=================================\n");
            Console.WriteLine($"Result: {F1 != F2}");

            Console.WriteLine("=================================\n");
            Console.WriteLine($"Result: {F1 >= F2}");

            Console.WriteLine("=================================\n");
            Console.WriteLine($"Result: {F1 <= F2}");
            
            Console.WriteLine("=================================\n");
            Console.WriteLine($"Result: {Res.ToString()}");

            Console.WriteLine("=================================\n");
            Console.WriteLine($"Result: {Res.GetFraction()}");
            Res = Fraction.Parse("10");
            Console.WriteLine("=================================\n");
            Console.WriteLine($"Result: {Res}" );
            Res = Fraction.Parse("1/90");
            Console.WriteLine("=================================\n");
            Console.WriteLine($"Result: {Res}");
            Res = Fraction.Parse("999,99");
            Console.WriteLine("=================================\n");
            Console.WriteLine($"Result: {Res}");
            Res = Fraction.Parse("123123.123123443");
            Console.WriteLine("=================================\n");
            Console.WriteLine($"Result: {Res}");

        }
    }
}
