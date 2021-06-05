using System;
namespace Lab._05
{
    class CoVidPatient : Patient, IShowNameAndDiagnosis
    {
        public string ImportantInfo { get; set; }
        public CoVidPatient()
        {
            ImportantInfo = "None";
        }
        public CoVidPatient(string firstName, string secondName, string fathersName)
        {
            FirstName = firstName ;
            SecondName = secondName;
            FathersName = fathersName;
        }

        public string ShowName()
        {
            Console.WriteLine(FirstName, " ", SecondName, " ", FathersName);
            return (SecondName);
        }
        public string ShowDiagnosis()
        {
            Console.WriteLine("CO-VID19");
            return ("CO-VID19");
        }
        public override void GetFullInfo()
        {
            base.GetFullInfo();
            Console.WriteLine("\n!WARNING!");
            Console.WriteLine("!COVID PATIENT!\n");
            Console.WriteLine($"DaysOfStaying: {DaysOfStaying}");
            Console.WriteLine($"ImportantInfo: {ImportantInfo}");


        }
    }

}
