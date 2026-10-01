using System.Threading.Channels;
using System.Xml.Linq;

namespace ooparv
{
    internal class GermanShepherd : Dog
    {
        public GermanShepherd()
        {

        }

        public GermanShepherd(string name, int age, double weight, eHabitat habitat, bool isDomesticicated,bool isTrained)
            : base (name,age,weight,habitat,isDomesticicated,isTrained)

        {
             
        }

        public override void MakeSound() => Console.WriteLine($"The dog {Name} says: LOUD WOFF WOFF");

        public override void Guarding() => Console.WriteLine("Guarding intensely, very vigilant");

        public override void Cleaning() => Console.WriteLine("happily bathing");




    }
}
