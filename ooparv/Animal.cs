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
    abstract class Animal
    {


        public Animal(string name, int age, double weight, eHabitat habitat, bool isDomesticicated)
        {

            Name = name;
            Age = age;
            Weight = weight;
            Habitat = habitat;
            IsDomesticated = isDomesticicated; 
        }

        public string Name { get; set; } = "Unknown";
        public int Age { get; set; } = -1;
        public double Weight { get; set; } = -1;
        public eHabitat Habitat { get; set; } = eHabitat.Unknown;
        public bool IsDomesticated { get; set; }

        public abstract void MakeSound();
        public abstract void Eating();
        public abstract void Cleaning();

        public void PrintAnimalInfo()
        {
            Console.WriteLine($"Name: {Name}" +
                $"\nAge: {Age}" +
                $"\nWeight: {Weight}kg" +
                $"\nHabitat: {Habitat}" +
                $"\nIsDomesticated {IsDomesticated}\n\n");
        }



    }
}
