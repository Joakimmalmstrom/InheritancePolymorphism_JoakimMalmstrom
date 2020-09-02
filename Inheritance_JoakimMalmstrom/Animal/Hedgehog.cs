namespace Inheritance_JoakimMalmstrom
{
    public class Hedgehog : Animal
    {
        public int NumSpikes { get; set; }
        public Hedgehog(string name, int age, double weight, int numSpikes) : base(name, age, weight)
        {
            base.Name = name;
            base.Age = age;
            base.Weight = weight;
            NumSpikes = numSpikes;
        }
        
        public override string DoSound()
        {
            return "SEGA";
        }

        public override string Stats()
        {
            return base.Stats() + $" {NumSpikes.ToString()}";
        }
    }
}