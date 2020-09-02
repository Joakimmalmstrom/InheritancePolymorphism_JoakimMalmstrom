using System.Runtime.InteropServices;

namespace Inheritance_JoakimMalmstrom
{
    abstract public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        // Question 2: Add additional property for all the animals
        public Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
        
        abstract public string DoSound();
        virtual public string Stats()
        {
            return $"{Name} {Age} {Weight}";
        }
    }
}