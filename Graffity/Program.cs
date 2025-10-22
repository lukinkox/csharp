// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design.Serialization;
using System.Numerics;
using System.Reflection.PortableExecutable;

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("Zadajte pismeno");

string input = Console.ReadLine();
  string output = "";
string[,] matrix = new string[40, 100];
int offset = 0;

foreach (char intputLetter in input)
{
    string outletters = GetLetter(intputLetter.ToString());
    string[] lines = outletters.Split(Environment.NewLine);
    int letterWidth = 0;

    for (int i = 0; i < lines.Length; i++)
    {
        string character = lines[i];
        letterWidth = Math.Max(lines[i].Length, letterWidth);
        for (int j = 0; j < character.Length; j++)
        {
            matrix[i, j + offset] = character[j].ToString();
        }
        offset = offset + letterWidth;
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}


Console.WriteLine(output);

string GetLetter(string input)
{
    switch (input)
    {
        case "a":
        case "A":
        case "á":
        case "Á":
            return GetLetterA();
        case "b":
        case "B":
            return GetLetterB();
        case "c":
        case "C":
            return GetLetterC();
        case "d":
        case "D":
            return GetLetterD();
        case "e":
        case "E":
            return GetLetterE();
        case "f":
        case "F":
            return GetLetterF();
        case "g":
        case "G":
            return GetLetterG();
        case "h":
        case "H":
            return GetLetterH();
        case "i":
        case "I":
            return GetLetterI();
        case "j":
        case "J":
            return GetLetterJ();
        case "k":
        case "K":
            return GetLetterK();
        case "l":
        case "L":
            return GetLetterL();
        case "m":
        case "M":
            return GetLetterM();
        case "n":
        case "N":
            return GetLetterN();
        case "o":
        case "O":
            return GetLetterO();
        case "p":
        case "P":
            return GetLetterP();
        case "r":
        case "R":
            return GetLetterR();
        case "s":
        case "S":
            return GetLetterS();
        case "t":
        case "T":
            return GetLetterT();
        case "u":
        case "U":
            return GetLetterU();
        case "v":
        case "V":
            return GetLetterV();
        case "w":
        case "W":
            return GetLetterW();
        case "x":
        case "X":
            return GetLetterX();
        case "y":
        case "Y":
            return GetLetterY();
        case "z":
        case "Z":
            return GetLetterZ();

        default:
            return "Pismeno nie je podporované";
    }
}

Console.WriteLine(output);

string GetLetterA()
{
    return @"
 ____ 
/  _ \
| / \|
| |-||
\_/ \|
       ";
}


Console.WriteLine(output);

string GetLetterB()
{
    return @"
 ____ 
/  __\
| | //
| |_\\
\____/";
}



string GetLetterC()
{
    return @"
 ____ 
/   _\
|  /  
|  \__
\____/";
}



string GetLetterD()
{
    return @"
 ____ 
/  _ \
| | \|
| |_/|
\____/";
}


string GetLetterE()
{
    return @"
 _____
/  __/
|  \  
|  /_ 
\____\";
}



string GetLetterF()
{
    return @"
 _____
/    /
|  __\
| |   
\_/ ";
}


string GetLetterG()
{
    return @"
 _____
/  __/
| |  _
| |_//
\____\";
}



string GetLetterH()
{
    return @"
 _    
/ \ /|
| |_||
| | ||
\_/ \|";
}


string GetLetterI()
{
    return @"
 _ 
/ \
| |
| |
\_/";
}



string GetLetterJ()
{
    return @"
    _ 
   / |
   | |
/\_| |
\____/";
}


string GetLetterK()
{
    return @"
 _  __
/ |/ /
|   / 
|   \ 
\_|\_\";
}



string GetLetterL()
{
    return @"
 _    
/ \   
| |   
| |_/\
\____/";
}


string GetLetterM()
{
    return @"
 _     
/ \__/|
| |\/||
| |  ||
\_/  \|";
}


string GetLetterN()
{
    return @"
 _     
/ \  /|
| |\ ||
| | \||
\_/  \|";
}


string GetLetterO()
{
    return @"
 ____ 
/  _ \
| / \|
| \_/|
\____/";
}


string GetLetterP()
{
    return @"
 ____ 
/  __\
|  \/|
|  __/
\_/ ";
}


string GetLetterR()
{
    return @"
 ____ 
/  __\
|  \/|
|    /
\_/\_\";
}

string GetLetterS()
{
    return @"
 ____ 
/ ___\
|    \
\___ |
\____/";
}




string GetLetterT()
{
    return @"
 _____ 
/__ __\
  / \  
  | |  
  \_/";
}


string GetLetterU()
{
    return @"
 _    
/ \ /\
| | ||
| \_/|
\____/";
}



string GetLetterV()
{
    return @"
 _    
/ \ |\
| | //
| \// 
\__/  ";
}




string GetLetterW()
{
    return @"
 _     
/ \  /|
| |  ||
| |/\||
\_/  \|";
}



string GetLetterX()
{
    return @"
___  _
\  \//
 \  / 
 /  \ 
/__/\\";
}


string GetLetterY()
{
    return @"
___  _
\  \//
 \  / 
 / /  
/_/";
}


string GetLetterZ()
{
    return @"
 ____ 
/_   \
 /   /
/   /_
\____/";
}

Console.ResetColor();