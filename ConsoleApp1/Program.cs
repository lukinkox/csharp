using AnimalsDop;

Dog dog = new Dog("Labrador");
dog.Name = "Hauko";
dog.age = 2;

Dinosaurus dinosaurus = new Dinosaurus ("T-Rex");
dinosaurus.Name = "Dino";
dinosaurus.age = 30;

Cat cat = new Cat("BritishCat");
cat.Name = "Mnauka";
cat.age = 1;


Snake snake = new Snake("Cobra");
snake.Name = "Petko";
snake.age = 4;


Fish fish = new Fish("GoldFish");
fish.Name = "Rybka";
fish.age = 1;


List<Animal> animals = new List<Animal>();
animals.Add(dog);
animals.Add(dinosaurus);
animals.Add(snake);
animals.Add(fish);

foreach (var animal in animals)
{
    animal.MakeSound();
    animal.Move();
    animal.Feed();
    animal.Feed("banana");

}