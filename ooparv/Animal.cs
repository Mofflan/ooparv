using System;
using System.Collections.Generic;
using System.Text;

namespace ooparv
{
    abstract class Animal
    {

        public string Name { get; set; }

        public int Age { get; set; }


        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }




    }
}
