namespace Inheritance_JoakimMalmstrom
{
    public class Swan : Bird
    {
        public int NumFeathers { get; set; }
        public Swan(string name, int age, double weight, double wingSpan, int numFeathers) : base(name, age, weight, wingSpan)
        {
            NumFeathers = numFeathers;
        }

        public override string Stats()
        {
            return base.Stats() + $" {NumFeathers.ToString()}";
        }
    }
}