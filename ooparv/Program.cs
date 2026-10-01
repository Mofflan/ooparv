namespace ooparv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jaguar jaguar = new Jaguar("Jaggy",9,45,eHabitat.Forest,false);
            Pig pig = new Pig("Bacon",9,56,eHabitat.Farm,false);
            Cat cat = new Cat("Kissemisse",3,14,eHabitat.Farm,true);
            //skapar german shepard
            GermanShepherd germanShepard = new GermanShepherd("Karl",5,45,eHabitat.Home,true,true);
            //Skapar dog objekt med värde
            Dog dog = new Dog("Kent", 3, 12.4, eHabitat.Home, true,false);
            //Skapar dog objekt som får defualt värde
            Dog dogDefault = new Dog();
            Console.WriteLine("Dog med default värde:");
            dogDefault.PrintAnimalInfo();
            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            Console.WriteLine("Dog:");
            dog.PrintAnimalInfo();
            dog.Cleaning();
            dog.MakeSound();
            dog.IsTrained();
            dog.Eating();
            dog.Guarding();

            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Dog German Shepard:");
            germanShepard.PrintAnimalInfo();
            germanShepard.Cleaning();
            germanShepard.MakeSound();
            germanShepard.IsTrained();
            germanShepard.Eating();
            germanShepard.Guarding();


            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Cat:");
            cat.PrintAnimalInfo();
            cat.Cleaning();
            cat.MakeSound();
            cat.Eating();
            cat.Guarding();
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Jaguar:");
            jaguar.PrintAnimalInfo();
            jaguar.Cleaning();
            jaguar.Eating();
            jaguar.MakeSound();
            jaguar.Guarding();
            
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Pig:");
            pig.PrintAnimalInfo();
            pig.Cleaning();
            pig.MakeSound();
            pig.Eating();
            pig.Guarding();


        }
    }
}
