namespace Lab._03
{
    class Human
    {
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
        public Human()
        {
            FirstName = SecondName = FathersName = "None";
            Gender = Genders.None;
            Weight = Height = 0;
            InterestingFacts = "None";
        }
    }
}
