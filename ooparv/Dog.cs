using System.Threading.Channels;

namespace ooparv
{
    internal class Dog : Animal
    {
        private bool myIsTrained = false; // Dog egna egenskap

        public Dog() { }
        public Dog(string name, int age, double weight, eHabitat habitat, bool isDomesticicated, bool isTrained)
          : base(name, age, weight, habitat, isDomesticicated)
        {
            Name = name;
            myIsTrained = isTrained;
        }

        public override void MakeSound() => Console.WriteLine($"The dog {Name} says: Woof Woof");
        public override void Guarding() => Console.WriteLine("Guarding Normally");
        // Dog egna metod
        public void IsTrained() => Console.WriteLine($"Dog trained: {myIsTrained}"); 

        public override void Cleaning() => Console.WriteLine("Bathing");


    }
}
