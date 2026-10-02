namespace ooparv
{
    internal enum eHabitat
    {
        Home,
        Forest,
        Farm,
        Desert,
        Ocean,
        Unknown

    }
    internal abstract class Animal
    {


        protected string Name { get; set; } = "Unknown";
        private int Age { get; set; } = -1;
        private double Weight { get; set; } = -1;
        private eHabitat Habitat { get; set; } = eHabitat.Unknown;
        private bool IsDomesticated { get; set; } = false;

        protected Animal() { }
        protected Animal(string name, int age, double weight, eHabitat habitat, bool isDomesticicated)
        {

            Name = name;
            Age = age;
            Weight = weight;
            Habitat = habitat;
            IsDomesticated = isDomesticicated;
        }

        public abstract void MakeSound();
        public abstract void Cleaning();
        public abstract void Guarding();

        public void Eating() => Console.WriteLine($"{Name} is eating");

        public void PrintAnimalInfo()
        {
            Console.WriteLine($"\nName: {Name}" +
                $"\nAge: {Age}" +
                $"\nWeight: {Weight}kg" +
                $"\nHabitat: {Habitat}" +
                $"\nIsDomesticated {IsDomesticated}\n");
        }



    }
}
