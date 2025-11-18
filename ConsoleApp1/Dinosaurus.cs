namespace AnimalsDop
{
    internal class Dinosaurus : Animal 

    {
        public Dinosaurus (string Personality) : base (Personality)
        {
            SoundName = "Dinosaurus.wav";
        }
        public override void Move()
        {
            Console.WriteLine("Dinosaur is being loud");
        }
    }
}
