using System;

namespace Lab._05
{
    class Patient : Human
    {
        public enum Deseases
        {
            Infections,
            MechanicalDamage,
        }
        public enum CorpusNumbers
        {
            FirstCorpus,
            SecondCorpus,
            ThirdCorpus,
        }
        public int PatientNumber { get; set; }
        public int ChamblerNumber { get; set; }
        public Deseases Desease { get; set; }
        public CorpusNumbers CorpusNumber { get; set; }      
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("\nPatinetInfo: ");
            Console.WriteLine($"CorpusNumber: {CorpusNumber}");
            Console.WriteLine($"ChamblerNumber: {ChamblerNumber}");
            Console.WriteLine($"Desease: {Desease}");
            Console.WriteLine($"PatientNumber: {PatientNumber}");
        }
    }
}
