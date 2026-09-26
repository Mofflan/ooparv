namespace ooparv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Kent",3,12.4,eHabitat.Home,true);

            dog.PrintAnimalInfo();
            //Pig pig = new Pig();
            //Cat cat = new Cat();
           

            dog.MakeSound();
            //pig.MakeSound();
            //cat.MakeSound();
            

        }
    }
}
