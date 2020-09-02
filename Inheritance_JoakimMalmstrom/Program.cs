using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_JoakimMalmstrom
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: See -> Bird.cs
            // Question 2: See -> Animal.cs
            // Question 3: Animal or Horse is not of the type Dog. 
            // Question 4: The list must be of type Animal because that's what all of them inherit from
            // Question 5: It prints all the stats from the base class of Animal and then prints the override method from the sub-class
            // Question 6: Animals does not inherit the sub-class method Bark
            // Question 7: You easily have a structured code and able cast to specific methods from the sub-classes
            // Question 8: It saves a lot of time if you need to make changes and easy to follow the code's logic
            // Question 9: A class can have multiple interfaces but only one inherited (abstract) class
            //             One can define a method in an abstract class, you cannot do that in interface

            // ANIMALS

            //Animal horse = new Horse("Shadowfax", 10, 200, true);
            //Wolf wolfman = new Wolfman("Wolfie", 13, 13, true);
            //Bird bird = new Bird("Bird", 15, 150, 150);
            //Bird pelican = new Pelican("Pelican", 20, 13, 50, 20);
            //Dog labrador = new Dog("Laika", 6, 30, "Labrador");
            //Dog rotweiler = new Dog("Tanja", 10, 45, "rotweiler");

            //List<Animal> animals = new List<Animal>() { horse, wolfman, bird, pelican, rotweiler };
            //List<Dog> dogs = new List<Dog>() { labrador, rotweiler, /*horse*/};

            //foreach (var a in animals)
            //{
            //    var tempInterface = a as IPerson;
            //    var tempDog = a as Dog;

            //    if (tempInterface is IPerson)
            //    {
            //        PrintWolfMan(a.Name, a.DoSound(), tempInterface.Talk());
            //    }
            //    else if (tempDog is Dog)
            //    {
            //        PrintDog(a.Name, a.DoSound(), a.Stats(), tempDog.Bark());
            //    }
            //    else
            //    {
            //        PrintAnimal(a.Name, a.DoSound());
            //    }
            //}

            // USER ERRORS

            UserError numeric = new NumericInputError();
            UserError text = new TextInputError();
            UserError blank = new BlankError();
            UserError special = new SpecialCharacterError();
            UserError invalid = new InvalidCharacterError();

            List<UserError> userErrors = new List<UserError>() { numeric, text, blank, special, invalid };

            foreach (var u in userErrors)
            {
                Console.WriteLine(u.UEMessage());
            }

            Console.ReadLine();
        }
        public static void PrintWolfMan(string name, string sound, string talk)
        {
            Console.WriteLine($"Animal: {name} || Sound: {sound} || Talks: {talk}");
        }

        public static void PrintDog(string name, string sound, string stats, string bark)
        {
            Console.WriteLine($"Animal: {name} || Sound: {sound} || Stats: {stats} || Bark: {bark}");
        }

        public static void PrintAnimal(string name, string sound)
        {
            Console.WriteLine($"Animal: {name} || Sound: {sound}");
        }
    }
}
