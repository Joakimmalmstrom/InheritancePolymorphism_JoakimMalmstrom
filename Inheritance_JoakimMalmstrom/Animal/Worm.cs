namespace Inheritance_JoakimMalmstrom
{
    public class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public Worm(string name, int age, double weight, bool isPoisonous) : base(name, age, weight)
        {
            IsPoisonous = isPoisonous;
        }
        
        public override string DoSound()
        {
            return "TsssSsss";
        }

        public override string Stats()
        {
            return base.Stats() + $" {IsPoisonous.ToString()}";
        }
    }
}