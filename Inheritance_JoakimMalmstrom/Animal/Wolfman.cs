namespace Inheritance_JoakimMalmstrom
{
    public class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, double weight, bool isPackLeader) : base(name, age, weight, isPackLeader)
        {
            base.Name = name;
            base.Age = age;
            base.Weight = weight;
            base.IsPackLeader = isPackLeader;
        }

        public string Talk()
        {
            return "'Cause this is thriller, thriller night";
        }
    }
}