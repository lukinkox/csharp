//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using System.Numerics;

//List<int> numbers = new List<int> {1, 2, 3, 4, 2, 9, 6, 7, 8, 9, 10};
//foreach (int number in numbers)
//{
//    Console.WriteLine();
//}




//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<char> cisla = new List<char>();
//        Console.WriteLine("ZADAJ CISLA");
//        string vstup = Console.ReadLine();
//        while (true)
//        {
//            char znak = Console.ReadKey(true).KeyChar; 

//            if (znak == '+')
//                break;

//            cisla.Add(znak);
//            Console.WriteLine(znak);
//        }
//    }
//}



Console.WriteLine("Zadaj Meno");
string meno = Console.ReadLine();
Console.WriteLine("Zadaj Vek");
string vek = Console.ReadLine();

Console.WriteLine($"Ahoj {meno}.Tvoj vek je {vek} rokov");

VypisUdaje(meno, vek);

string ZiskajMeno()
{
    Console.WriteLine("Zadaj Meno");
    string meno = Console.ReadLine();
    return meno;
}

string ZiskajVek()
{
    Console.WriteLine("Zadaj Vek");
    string vek = Console.ReadLine();
    return vek;
}

void VypisUdaje(string meno, string vek)
{
    Console.WriteLine($"Ahoj {meno}.Tvoj vek je {vek} rokov");
}
