using System;

namespace Lab._05
{
    class AnotherInfectionPatient : Patient, IShowNameAndDiagnosis
    {
        public AnotherInfectionPatient()
        {
            Desease = Deseases.Infections;
        }                    
        public AnotherInfectionPatient (string firstName, string secondName, string fathersName)
        {
            FirstName = firstName;
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
            Console.WriteLine("Infection");
            return ("Infection");
        }
    }
}
