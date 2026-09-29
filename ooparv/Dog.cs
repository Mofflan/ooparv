using System.Threading.Channels;

namespace ooparv
{
    internal class Dog : Animal
    {
        private string myName;
        private bool myIsTrained = false; 
        public Dog() { }
        public Dog(string name, int age, double weight, eHabitat habitat, bool isDomesticicated)
          : base(name, age, weight, habitat, isDomesticicated)
        {
            myName = name;
        }

        public void Fetch() => Console.WriteLine("Fetching...");
        public override void MakeSound() => Console.WriteLine($"The dog {myName} says: Woof Woof");
        public override void Guarding() => Console.WriteLine("Guarding Normally");

        public void IsTrained() => Console.WriteLine($"Dog trained: {myIsTrained}");

        public override void Cleaning()
        {
            throw new NotImplementedException();
        }


    }
}
