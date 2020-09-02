namespace Inheritance_JoakimMalmstrom
{
    public class Flamingo : Bird
    {
        public double LegLength { get; set; }
        public Flamingo(string name, int age, double weight, double wingSpan, double legLength) : base(name, age, weight, wingSpan)
        {
            base.Name = name;
            base.Age = age;
            base.Weight = weight;
            base.WingSpan = wingSpan;
            LegLength = legLength;
        }

        public override string Stats()
        {
            return base.Stats() + $" {LegLength.ToString()}";
        }

    }
}