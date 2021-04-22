using System;
namespace Lab._05
{
    class CoVidPatient : Patient
    {
        public int DaysOfStaying { get; set; }
        public string ImportantInfo { get; set; }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("\n!WARNING!");
            Console.WriteLine("!COVID PATIENT!\n");
            Console.WriteLine($"DaysOfStaying: {DaysOfStaying}");
            Console.WriteLine($"ImportantInfo: {ImportantInfo}");


        }
    }

}
