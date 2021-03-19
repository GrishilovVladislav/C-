using System;


namespace Lab._02._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = 0;
            foreach (char ch in str)
                if (Char.IsUpper(ch) && !(ch >= 'A' && ch <= 'Z'))
                    count++;
            Console.WriteLine(count);
        }
    }
}
