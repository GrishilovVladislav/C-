using System;

namespace Lab._02._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            string[] words = str.Split();
            Array.Reverse(words);
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}
