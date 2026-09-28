using System.Threading.Channels;

namespace ooparv
{
    internal class Dog : Animal
    {
        public bool IsTrained { get; set; } = false;
        public Dog() { }
        public Dog(string name, int age, double weight, eHabitat habitat, bool isDomesticicated)
          : base(name, age, weight, habitat, isDomesticicated)
        {

        }

        public void Fetch() => Console.WriteLine("Fetching...");
        public override void MakeSound() => Console.WriteLine("The dog says: Woof Woof");
        public override void Guarding() => Console.WriteLine("Guarding Normally");



        public override void Cleaning()
        {
            throw new NotImplementedException();
        }


    }
}
