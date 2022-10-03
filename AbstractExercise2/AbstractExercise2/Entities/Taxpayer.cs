namespace AbstractExercise2.Entities
{
    public abstract class Taxpayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Taxpayer()
        {
        }

        public Taxpayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxesPaid();
    }
}
