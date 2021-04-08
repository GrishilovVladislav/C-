using System;

namespace Lab._03
{
   class Program
    {
        static void Main(string[] args)
        {
            Human H1 = new Human();
            H1.Gender = Human.Genders.Male;
            H1.FirstName = "Alexander";
            H1.SecondName = "Shlyapik";
            H1.FathersName = "Alexandrovich";
            H1.Age = 54;
            H1.Height = 176;
            H1.Weight = 65;
            H1.InterestingFacts = "Supports the far-right ";
            H1.HumanRace = Human.Race.European;
            Console.WriteLine($"Gender: {H1.Gender}");
            Console.WriteLine($"Race: {H1.HumanRace}");
            Console.WriteLine($"Name: {H1.FirstName} {H1.SecondName} {H1.FathersName} ");
            Console.WriteLine($"Age: {H1.Age}");
            Console.WriteLine($"Height: {H1.Height}");
            Console.WriteLine($"Weight: {H1.Weight}");
            Console.WriteLine($"Special: {H1.InterestingFacts}");
            Console.WriteLine($"\n====================\n" );

            Human H2 = new Human();
            H2.Gender = Human.Genders.Female;
            H2.FirstName = "Svetlana";
            H2.SecondName = "Shlyapik";
            H2.FathersName = "Ibragimovna";
            H2.Age = 46;
            H2.Height = 198;
            H2.Weight = 96;
            H2.InterestingFacts = "Master of sports in kickboxing ";
            H2.HumanRace = Human.Race.Asian;
            Console.WriteLine($"Gender: {H2.Gender}");
            Console.WriteLine($"Race: {H2.HumanRace}");
            Console.WriteLine($"Name: {H2.FirstName} {H2.SecondName} {H2.FathersName} ");
            Console.WriteLine($"Age: {H2.Age}");
            Console.WriteLine($"Height: {H2.Height}");
            Console.WriteLine($"Weight: {H2.Weight}");
            Console.WriteLine($"Special: {H2.InterestingFacts}");
            Humans Humans = new Humans();
            Humans[0] = H1;
            Humans[1] = H2;
            
        }
    }
}
