using System;

namespace Lab._05
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
            H1.GetFullInfo();
            Console.WriteLine($"\n====================\n");
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
            H2.GetFullInfo();
            Humans Humans = new Humans();
            Humans[0] = H1;
            Humans[1] = H2;
            Console.WriteLine($"\n====================\n");
            CoVidPatient C1 = new CoVidPatient();
            C1.Gender = Human.Genders.Male;
            C1.FirstName = "Ivan";
            C1.SecondName = "Ivanov";
            C1.FathersName = "Andreevich";
            C1.Age = 58;
            C1.Height = 180;
            C1.Weight = 75;
            C1.InterestingFacts = "The General of the Armed Forces";
            C1.HumanRace = Human.Race.European;
            C1.CorpusNumber = Patient.CorpusNumbers.FirstCorpus;
            C1.ChamblerNumber = 10;
            C1.PatientNumber = 304;
            C1.Desease = Patient.Deseases.Infections;
            C1.DaysOfStaying = 14;
            C1.ImportantInfo = "Very hard situation";
            C1.GetFullInfo();
            Console.WriteLine($"\n====================\n");

            Human human = new CoVidPatient();

            human.GetFullInfo();
            Console.WriteLine($"\n====================\n");
            IShowNameAndDiagnosis[] list = { new CoVidPatient(), new MechanicDeseasePatient(), new AnotherInfectionPatient()};
            foreach(var patient in list)
            {
                Console.WriteLine($"\n");
                patient.ShowName();
                patient.ShowDiagnosis();
                Console.WriteLine($"\n====================\n");
            }
            

        }
    }
    
}
