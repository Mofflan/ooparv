namespace ooparv
{
    abstract class Animal
    {

        public Animal() { }

        public Animal(Animal aAnimal) { }
    
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; } = -1;
        public double Weight { get; set; } = -1;
        public string Habitat { get; set; } = "Unknown";
        public bool IsDomesticated { get; set; }

        public abstract void MakeSound();
        public abstract void Eating();
        public abstract void Cleaning();




    }
}
