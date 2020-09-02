namespace Inheritance_JoakimMalmstrom
{
    public class Pelican : Bird
    {
        public double BeakLength { get; set; }
        public Pelican(string name, int age, double weight, double wingSpan, double beakLength) : base(name, age, weight, wingSpan)
        {
            base.Name = name;
            base.Age = age;
            base.Weight = weight;
            base.WingSpan = wingSpan;
            BeakLength = beakLength;
        }

        public override string Stats()
        {
            return base.Stats() + $" {BeakLength.ToString()}";
        }
    }
}