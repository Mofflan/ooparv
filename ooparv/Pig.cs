using System;
using System.Collections.Generic;
using System.Text;

namespace ooparv
{
    internal class Pig : Animal
    {

        public Pig(string name, int age, double weight, eHabitat habitat, bool isDomesticicated)
            : base (name,age,weight,habitat,isDomesticicated)
        {}

        public override void Cleaning() => Console.WriteLine("Cleaning itself in mud");

        public override void Guarding() => Console.WriteLine("Sleeping while guarding??");

        public override void MakeSound() => Console.WriteLine($"The Pig {Name} says: Oink Oink");






    }
}
