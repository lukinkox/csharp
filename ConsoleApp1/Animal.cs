using System.Media;

namespace AnimalsDop
{
    internal class Animal
    {
        private string Path = "C:\\Users\\Lukas\\source\\repos\\csharp\\Souds\\";
        public string Name { get; set; }
        public int age { get; set; }
        public Animal(string Personality)
        {
            Personality = Personality;
        }
        protected string SoundName { get; set; }

        private string Personality { get; set; }
        public void MakeSound()
        {
            string soundFile = Path + SoundName;
            SoundPlayer player = new SoundPlayer(soundFile);
            player.PlaySync();


        }

        public void Feed()
        {
            Console.WriteLine("Feeding");
        }

        public void Feed(string mealName)
        {
            Console.WriteLine("Feeding " + mealName);
        }

        public virtual void Move()
        {
            Console.WriteLine();
        }
    }
}
