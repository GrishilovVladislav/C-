using System;

namespace Lab._02._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Time1 = DateTime.Now.ToString("F");
            string Time2 = DateTime.Now.ToString("G");
            Console.WriteLine(Time1);
            Console.WriteLine(Time2);
            char[] ch1 = Time1.ToCharArray();
            char[] ch2 = Time2.ToCharArray();
            string Time = Time1 + Time2;
            int count;
            for (byte i = 0; i < 10; i++)
            {
                count = 0;
                foreach (char ch in Time)
                {
                    if (Char.IsDigit(ch))
                    {
                        int digit = int.Parse(ch.ToString());
                        if (digit == i)
                        {
                            count++;
                        }
                    }
                }

                Console.WriteLine("Количество " + i + " - " + count);
            }
        }    
    }
}
