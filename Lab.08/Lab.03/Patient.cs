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
        public int DaysOfStaying { get; set; }
        public int PatientNumber { get; set; }
        public int ChamblerNumber { get; set; }
        public Deseases Desease { get; set; }
        public CorpusNumbers CorpusNumber { get; set; }
        public delegate void Message(string message);
        public event Message Note;
        public int Bill;
        public void GetFinalBillWithoutPrivileges(int days)
        {
            double Summ = days * 25;
            Note?.Invoke($"You need to pay {Summ} in registration center");
        }
        public void GetFinalBillWithPrivileges(int days)
        {
            double Summ = (days * 25) * 0.8 - 2.5;
            Note?.Invoke($"You need to pay {Summ} in registration center");
        }
        public Patient()
        {
            Bill = 0;
            DaysOfStaying = 0;
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
