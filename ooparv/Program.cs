namespace ooparv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            STYRKOR:

            använder arv och polymorfis.
            lämpliga access modifier används.



            SVAGHETER:

            Det ser kaos ut i main, gjorde massa extra grejer för vill inte få komplettering efter 5 veckor,
            fattade inte i början vad uppgiften ville ha för svar för godkänd så printar också ut lite extra grejer

            skulle nog säga global enum också är illa, att ha det nested i Animal så måste jag skriva Animal.Habitat.BlaBla vilket är riktigt ful kod tycker jag,
            känns fel. det är ändå i namespace ooparv så lite rimligt att ha det global.

            */

            Dog dogDefault = new Dog();

            Console.WriteLine("Dog med default värde:");
            dogDefault.PrintAnimalInfo();
          
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Dog dog = new Dog("Kent", 3, 12.4, eHabitat.Home, true, false);

          
            Console.WriteLine("Dog:");
            dog.PrintAnimalInfo();
            dog.Cleaning();
            dog.MakeSound();
            dog.IsTrained(); // dog egna metod 
            dog.Eating();
            dog.Guarding();

            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            GermanShepherd germanShepard = new GermanShepherd("Karl", 5, 45, eHabitat.Home, true, true);
           
            Console.WriteLine("Dog German Shepard:");
            germanShepard.PrintAnimalInfo();
            germanShepard.Cleaning();
            germanShepard.MakeSound();
            germanShepard.IsTrained();
            germanShepard.Eating();
            germanShepard.Guarding();
            germanShepard.Dancing(); //GermanShepard egna metod

            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            Cat cat = new Cat("Kissemisse", 3, 14, eHabitat.Farm, true);
          
            Console.WriteLine("Cat:");
            cat.PrintAnimalInfo();
            cat.Cleaning();
            cat.MakeSound();
            cat.Eating();
            cat.Guarding();
            cat.Talking();// Cat egna metod
            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            Jaguar jaguar = new Jaguar("Jaggy", 9, 45, eHabitat.Forest, false);
        
            Console.WriteLine("Jaguar:");
            jaguar.PrintAnimalInfo();
            jaguar.Cleaning();
            jaguar.Eating();
            jaguar.MakeSound();
            jaguar.Guarding();
            jaguar.Jump();// Jaguar egna metod
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
        
            Pig pig = new Pig("Bacon", 9, 56, eHabitat.Farm, true);
        
            Console.WriteLine("Pig:");
            pig.PrintAnimalInfo();
            pig.Cleaning();
            pig.MakeSound();
            pig.Eating();
            pig.Guarding();
            pig.Hungry(); // Pig egna metod


        }
    }
}
