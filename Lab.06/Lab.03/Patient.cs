using System;

namespace Lab._05
{
    class Patient : Human
    {
        public enum Deseases
        {
            Infections,
            MechanicalDamage,
            None,
        }
        public enum CorpusNumbers
        {
            FirstCorpus,
            SecondCorpus,
            ThirdCorpus,
            None,
        }
        public int PatientNumber { get; set; }
        public int ChamblerNumber { get; set; }
        public Deseases Desease { get; set; }
        public CorpusNumbers CorpusNumber { get; set; }      
        public Patient()
        {
            PatientNumber = 0;
            ChamblerNumber = 0;
            Desease = Deseases.None;
            CorpusNumber = CorpusNumbers.None;
        }
        
        public override void GetFullInfo()
        {
            base.GetFullInfo();
            Console.WriteLine("\nPatinetInfo: ");
            Console.WriteLine($"CorpusNumber: {CorpusNumber}");
            Console.WriteLine($"ChamblerNumber: {ChamblerNumber}");
            Console.WriteLine($"Desease: {Desease}");
            Console.WriteLine($"PatientNumber: {PatientNumber}");
        }
    }

}
