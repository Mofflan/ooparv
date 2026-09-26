namespace ooparv
{
    abstract class Animal
    {


        public string AnimalName { get; set; } = "Unknow";
        public int AnimalAge { get; set; }


        public abstract void MakeSound();
        public abstract void Eating();
        public abstract void Cleaning();




    }
}
