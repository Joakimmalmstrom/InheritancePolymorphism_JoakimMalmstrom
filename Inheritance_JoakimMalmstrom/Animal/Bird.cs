namespace Inheritance_JoakimMalmstrom
{
    public class Bird : Animal
    {
        public double WingSpan { get; set; }

        // Question 1: Add additional property for all the birds
        public Bird(string name, int age, double weight, double wingSpan) : base(name, age, weight)
        {
            WingSpan = wingSpan;
        }
        
        public override string DoSound()
        {
            return "Pip pip pip";
        }

        public override string Stats()
        {
            return base.Stats() + $" {WingSpan.ToString()}";
        }
    }
}