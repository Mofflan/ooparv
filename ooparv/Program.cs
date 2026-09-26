namespace ooparv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Pig pig = new Pig();
            Cat cat = new Cat();
           

            dog.test();
            dog.MakeSound();
            pig.MakeSound();
            cat.MakeSound();
            

        }
    }
}
