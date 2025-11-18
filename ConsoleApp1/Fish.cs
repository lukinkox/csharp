using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsDop
{
    internal class Fish : Animal
    {
        public Fish(string Personality) : base (Personality)
        {
            SoundName = "Fish.wav";
        }

        public override void Move()
        {
            Console.WriteLine("Fish is swimming");
        }
    }
}
