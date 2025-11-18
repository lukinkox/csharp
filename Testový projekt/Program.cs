using ClassApp;
using ConsoleApp1;

Player player = new Player();
player.SetName(name);
Monster monster = new Monster();

player.DealDamage(monster);
monster.DealDamage(player);
Console.WriteLine();

