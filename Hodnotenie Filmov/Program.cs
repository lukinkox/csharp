// See https://aka.ms/new-console-template for more information

class Program
{
    static List<string> filmy = new List<string>();
    static void Main()
    {
        int vyber = 0;
        while (vyber != 5)
        {

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("//     _____ _  _     _      ____  _    ___  _   ____  ____  ____  _      ____  _     \r\n//    /    // \\/ \\   / \\__/|/  _ \\/ \\ |\\\\  \\//  /_   \\/  _ \\/_   \\/ \\  /|/  _ \\/ \\__/|\r\n//    |  __\\| || |   | |\\/||| / \\|| | // \\  /    /   /| / \\| /   /| |\\ ||| / \\|| |\\/||\r\n//    | |   | || |_/\\| |  ||| \\_/|| \\//  / /    /   /_| \\_/|/   /_| | \\||| |-||| |  ||\r\n//    \\_/   \\_/\\____/\\_/  \\|\\____/\\__/  /_/     \\____/\\____/\\____/\\_/  \\|\\_/ \\|\\_/  \\|\r\n//                                                                                    ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Pridať nazov filmu");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2. Zobraziť všetky filmy");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("3. Vyhladať film");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("4. Odstraniť film");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("5. Ukončiť");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("6. Zobrazit Info");

            Console.ResetColor();
            Console.WriteLine("..............................");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Možnosť (1-6): ");
            Console.ResetColor();
            vyber = Convert.ToInt32(Console.ReadLine());

            if (vyber == 1)
            {
                PridajFilm();
            }
            else if (vyber == 2)
            {
                ZobrazFilmy();
            }
            else if (vyber == 3)
            {
                VyhladajFilm();
            }
            else if (vyber == 4)
            {
                VymazFilm();
            }
            else if (vyber == 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ukončenie programu");
                break;
            }
            else if (vyber == 6)
            {
                ZobrazInfo();
            }
            else
            {
                Console.WriteLine("Nespravna volba");
            }

            Console.WriteLine("\nStlac Enter pre navrat do menu...");
            Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine();


        }
    }

    static void PridajFilm()
    {

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Nazov filmu: ");
        Console.ResetColor();
        string nazov = Console.ReadLine();
        filmy.Add(nazov);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Film pridany.");
    }

    static void ZobrazFilmy()
    {
        if (filmy.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Zoznam je prazdny");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Zoznam filmov:");
            for (int i = 0; i < filmy.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + filmy[i]);
            }
        }
    }

    static void VyhladajFilm()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Zadaj nazov: ");
        Console.ResetColor();
        string hladany = Console.ReadLine();
        bool nasiel = false;

        for (int i = 0; i < filmy.Count; i++)
        {
            if (filmy[i].ToLower() == hladany.ToLower())
            {
                nasiel = true;
            }
        }

        if (nasiel)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Film najdeny");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Film sa nenasiel");
        }
    }

    static void VymazFilm()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Zadaj nazov filmu ktory chces vymazat: ");
        Console.ResetColor();
        string nazov = Console.ReadLine();
        bool vymazany = false;

        for (int i = 0; i < filmy.Count; i++)
        {
            if (filmy[i].ToLower() == nazov.ToLower())
            {
                if (filmy[i].ToLower() == nazov.ToLower())
                {
                    filmy.RemoveAt(i);
                    vymazany = true;
                    break;
                }
            }
            if (vymazany)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Film bol vymazany");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Film neexistuje");
            }

        }
    }
        static void ZobrazInfo()

        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vytvoril: Lukáš Maceašik");
            Console.WriteLine("Trieda: 1.AI");
            Console.ResetColor();
        }
    
}

        
