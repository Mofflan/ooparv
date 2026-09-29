namespace ooparv
{
    enum eHabitat
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

        public string Name { get; set; } = "Unknown";
        public int Age { get; set; } = -1;
        public double Weight { get; set; } = -1;
        public eHabitat Habitat { get; set; } = eHabitat.Unknown;
        public bool IsDomesticated { get; set; } = false;

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

        public void Eating() => Console.WriteLine($"{Name} is eating\n");

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
