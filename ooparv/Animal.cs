namespace ooparv
{
    enum eHabitat
    {
        Home,
        Forest,
        Farm,
        Unknown

    }
    abstract class Animal
    {
     

        public Animal(string name, int age, double weight, eHabitat habitat, bool isDomesticicated)
        {


        }

        public string Name { get; set; } = "Unknown";
        public int Age { get; set; } = -1;
        public double Weight { get; set; } = -1;
        public eHabitat test { get; set; }
        public bool IsDomesticated { get; set; }

        public abstract void MakeSound();
        public abstract void Eating();
        public abstract void Cleaning();




    }
}
