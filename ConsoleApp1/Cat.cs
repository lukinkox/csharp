using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsDop
{
    internal class Cat : Animal
    {
        public Cat (string Personality) : base (Personality)
        {
            SoundName = "Cat.wav";
        }

        public override void Move()
        {
            Console.WriteLine("Cat is meowing");
        }
    }
}
