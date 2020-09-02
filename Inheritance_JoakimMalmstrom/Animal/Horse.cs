namespace Inheritance_JoakimMalmstrom
{
    public class Horse : Animal
    {
        public bool Jump { get; set; }
        public Horse(string name, int age, double weight, bool jump) : base(name, age, weight)
        {
            base.Name = name;
            base.Age = age;
            base.Weight = weight;
            Jump = jump;
        }

        public override string DoSound()
        {
            return "Neigh";
        }

        public override string Stats()
        {
            return base.Stats() + $" {Jump.ToString()}";
        }
    }
}