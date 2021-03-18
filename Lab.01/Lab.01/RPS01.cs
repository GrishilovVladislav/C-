using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] items = new string[] { "Камень", "Ножницы", "Бумага" };
            int money = 10;
            do
            {
                Console.WriteLine("Правила очень просты: делаешь ставку (любое целое число) и играешь.");
                Console.WriteLine("Выиграть тут невозможно, но вот проиграть вполне, когда денег не останется.");
                Console.WriteLine("1- Камень 2- Ножницы 3- Бумага");
                Random rand = new Random();
                int computer = rand.Next(0, 2);
                Console.WriteLine("Ваш балланс : " + money + " даляров");
                Console.WriteLine("Ваша ставка : ");
                string a;
                a = Console.ReadLine();
                int bet = int.Parse(a);             
                if (bet > money)
                {
                    Console.WriteLine("Интересно, где вы столько денег возьмете, ведь у вас всего: " + money + " даляров");
                }
                else
                {
                    Console.WriteLine("К/Н/Б : ");
                    string human;
                    human = Console.ReadLine();
                    int code = byte.Parse(human);
                    switch (code)
                    {
                        case 1:
                            Console.WriteLine("Вы выбрали: " + items[0]);
                            Console.WriteLine("Компьютер выбрал: " + items[computer]);
                            if (computer == 0)
                            {
                                Console.WriteLine("Ничья!");
                            }
                            if (computer == 1)
                            {
                                Console.WriteLine("Вы победили!");
                                money = money + bet;
                                Console.WriteLine("Ваш балланс теперь составляет: " + money + " даляров");
                            }
                            if (computer == 2)

                            {
                                Console.WriteLine("Вы проиграли!");
                                money = money - bet;
                                Console.WriteLine("Ваш балланс теперь составляет: " + money + " даляров");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Вы выбрали: " + items[1]);
                            Console.WriteLine("Компьютер выбрал: " + items[computer]);
                            if (computer == 1)
                            {
                                Console.WriteLine("Ничья!");
                            }
                            if (computer == 2)
                            {
                                Console.WriteLine("Вы победили!");
                                money = money + bet;
                                Console.WriteLine("Ваш балланс теперь составляет: " + money + " даляров");
                            }
                            if (computer == 0)
                            {
                                Console.WriteLine("Вы проиграли!");
                                money = money - bet;
                                Console.WriteLine("Ваш балланс теперь составляет: " + money + " даляров");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Вы выбрали: " + items[2]);
                            Console.WriteLine("Компьютер выбрал: " + items[computer]);
                            if (computer == 2)
                            {
                                Console.WriteLine("Ничья!");
                            }
                            if (computer == 0)
                            {
                                Console.WriteLine("Вы победили!");
                                money = money + bet;
                                Console.WriteLine("Ваш балланс теперь составляет: " + money + " даляров");
                            }
                            if (computer == 1)
                            {
                                Console.WriteLine("Вы проиграли!");
                                money = money - bet;
                                Console.WriteLine("Ваш балланс теперь составляет: " + money + " даляров");
                            }
                            break;
                    }
                    if (code != 1 && code != 2 && code != 3)
                    {
                        Console.WriteLine("Какое " + code + "?! Сказано же: от 1 до 3 ввести...");
                    }
                    if (money == 0)
                    {
                        Console.WriteLine("К сожалению, вы банкрот! Нажмите любую клавишу для выхода.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }                                     
                }
                Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }
    }
}
