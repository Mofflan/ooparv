using System.Threading.Channels;

namespace ooparv
{
    internal class Dog : Animal
    {


        public Dog(string name, int age, double weight, eHabitat habitat, bool isDomesticicated)
          : base(name, age, weight, habitat, isDomesticicated)
        {

        }


        public override void MakeSound() => Console.WriteLine("The dog says: Woof Woof");
        public virtual void Guard() => Console.WriteLine("Guarding Normally");

        public override void Eating()
        {
            throw new NotImplementedException();
        }

        public override void Cleaning()
        {
            throw new NotImplementedException();
        }

        public void test()
        { }

    }
}
