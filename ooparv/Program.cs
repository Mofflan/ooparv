namespace ooparv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal pig = new Pig();
            Animal cat = new Cat();



            dog.MakeSound();
            pig.MakeSound();
            cat.MakeSound();

        }
    }
}
