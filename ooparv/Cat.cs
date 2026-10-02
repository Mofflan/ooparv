using System;
using System.Collections.Generic;
using System.Text;

namespace ooparv
{
    internal class Cat : Animal
    {

        private string egenskap = "cat egenskap";
        public Cat(string name, int age, double weight, eHabitat habitat, bool isDomesticicated)
            : base(name, age, weight, habitat, isDomesticicated)
        {

        }

        public override void Cleaning() => Console.WriteLine("Licking itself clean");
        public override void Guarding() => Console.WriteLine("Guarding and Growling...");
        public override void MakeSound() => Console.WriteLine($"The cat {Name} says: meow meow");
        //egen metod
        public void Talking() => Console.WriteLine("Talking");




    }
}
