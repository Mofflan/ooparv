namespace ooparv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapar dog objekt med värde
            Dog dog = new Dog("Kent", 3, 12.4, eHabitat.Home, true);
            //Skapar dog objekt som får defualt värde
            Dog dogDefault = new Dog();
            dogDefault.PrintAnimalInfo();
            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            Console.WriteLine("Dog:");
            dog.PrintAnimalInfo();
            dog.Eating();
            dog.MakeSound();
            dog.IsTrained();
            Console.WriteLine("--------------------------------------------------------------------------------------------------");




            //Pig pig = new Pig();
            //Cat cat = new Cat();

            //pig.MakeSound();
            //cat.MakeSound();


        }
    }
}
