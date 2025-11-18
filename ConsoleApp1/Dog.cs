namespace AnimalsDop
{
    internal class Dog : Animal
    {
        public Dog (string Personality) : base (Personality)
        {
            SoundName = "Dog.wav";

        }
        public override void Move()
        {
            Console.WriteLine("Dog is barking");
        }
    }
}
