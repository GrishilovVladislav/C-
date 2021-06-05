using System;

namespace Lab._05
{
    class MechanicDeseasePatient : Patient, IShowNameAndDiagnosis
    {
        public MechanicDeseasePatient()
        {
            Desease = Deseases.MechanicalDamage;
        }
        public MechanicDeseasePatient(string firstName, string secondName, string fathersName)
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
            Console.WriteLine("MechDamage");
            return ("MechDamage");
        }
    }
}
