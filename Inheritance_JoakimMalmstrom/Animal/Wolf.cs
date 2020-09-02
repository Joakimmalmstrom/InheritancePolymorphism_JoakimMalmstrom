namespace Inheritance_JoakimMalmstrom
{
    public class Wolf : Animal
    {
        public bool IsPackLeader { get; set; }

        public Wolf(string name, int age, double weight, bool isPackLeader) : base(name, age, weight)
        {
            base.Name = name;
            base.Age = age;
            base.Weight = weight;
            IsPackLeader = isPackLeader;
        }
        
        public override string DoSound()
        {
            return "Grrrr";
        }

        public override string Stats()
        {
            return base.Stats() + $" {IsPackLeader.ToString()}";
        }
    }
}