using System;

namespace Lab._05
{
    class Human
    {
        public enum Race
        {
            European,
            African,
            Arabian,
            Asian,
            NoInfo,
        }
        public enum Genders
        {
            Male,
            Female,
            None,
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FathersName { get; set; }
        public int Age { get; set; }
        public Genders Gender { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string InterestingFacts { get; set; }
        public Race HumanRace { get; set; }
        public Human()
        {
            FirstName = SecondName = FathersName = "None";
            Gender = Genders.None;
            Weight = Height = 0;
            HumanRace = Race.NoInfo;
            InterestingFacts = "None";
        }
        public Human(string name, string secondName, string fathersName, int age, double weight, double height, Genders gender)
        {
            FirstName = name;
            SecondName = secondName;
            FathersName = fathersName;
            Age = age;
            Gender = gender;
            Weight = weight;
            Height = height;
            Gender = gender;
        }
        public virtual void GetFullInfo()
        {
            Console.WriteLine("GeneralInfo: ");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Race: {HumanRace}");
            Console.WriteLine($"Name: {FirstName} {SecondName} {FathersName} ");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Special: {InterestingFacts}");
        }
    }
}
