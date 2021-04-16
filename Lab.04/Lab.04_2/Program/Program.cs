using System;
using System.Runtime.InteropServices;
namespace Lab._04_2
{
    class Program
    {
        [DllImport("../../Dll.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double Plus(double a, double b);
        [DllImport("../../Dll.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double Minus(double a, double b);
        [DllImport("../../Dll.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double Multi(double a, double b);
        [DllImport("../../Dll.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double Div(double a, double b);
        [DllImport("../../Dll.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double Pow(double a, int x);
        [DllImport("../../Dll.dll", CallingConvention = CallingConvention.StdCall)]
        static extern double Abs(double a);
        [DllImport("../../Dll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern double Greater(double a, double b);
        [DllImport("../../Dll.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Mod(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine(Plus(5, 10));
            Console.WriteLine(Minus(5, 10));
            Console.WriteLine(Multi(5, 10));
            Console.WriteLine(Div(5, 10));
            Console.WriteLine(Pow(5, 10));
            Console.WriteLine(Abs(100));
            Console.WriteLine(Greater(5, 10));
            Console.WriteLine(Mod(5, 10));
        }
    }
}
