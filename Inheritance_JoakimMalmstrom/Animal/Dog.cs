namespace Inheritance_JoakimMalmstrom
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, double weight, string breed) : base(name, age, weight)
        {
            Breed = breed;
        }

        public override string DoSound()
        {
            return "Woff";
        }

        public override string Stats()
        {
            return base.Stats() + $" {Breed}";
        }

        public string Bark()
        {
            return "Bark!";
        }
    }
}