using System;
using System.Collections.Generic;
using System.Text;

namespace ooparv
{
    internal class Jaguar : Cat
    {

        private string egenskap = "jaguar egenskap";

        public Jaguar(string name, int age, double weight, eHabitat habitat, bool isDomesticicated)
            : base(name, age, weight, habitat, isDomesticicated)
        {

        }

        //Jaguar egna metod
        public void Jump() => Console.WriteLine("Jumps high!");
        



    }
}
