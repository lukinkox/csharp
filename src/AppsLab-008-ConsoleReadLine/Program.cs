//Console.WriteLine("Ako sa voláš?");
//string? meno = Console.ReadLine();
//Console.WriteLine("Ahoj, " + meno + " Kolko máš rokov?");

//string vstup = Console.ReadLine() ?? "0";
//int vek = int.Parse(vstup);
//Console.WriteLine("Aha, máš teda " + vek + " rokov. ");


//Console.WriteLine("Aké je tvoje oblubené jedlo");
//    string? jedlo = Console.ReadLine();
//Console.WriteLine("Hmm, " + jedlo + " to znie skvelo.");


//Console.WriteLine("Ahoj vitaj v kalkulačke");
//string? prveCislo = Console.ReadLine();
//string? druheCislo = Console.ReadLine();
//int sucet = int.Parse(prveCislo) + int.Parse(druheCislo);
//Console.WriteLine($"Sucet: {sucet}");

//int a = 5;
//int b = 1;

//int sum = a + b;
//int difference = a - b;
//int product a * b;
//double division = (double)a / b;
//int remainder = (int)a % b;

//bool equality = a == b;
//bool inequality = a != b;
//bool greater = a > b;
//bool lesser = a < b;
//bool greaterEqual = a >= b;
//bool lesserEqual = a <= b;

//bool a = true;
//bool b = false;

//bool andBool = a && b;
//bool orBool = a || b;
//bool notA = !a;

//int c = 0;

//bool a = true;
//int b = 70;
//int c = 40;

//bool andbool1 = a && (b > c);
//bool andbool2 = a && (b == c);
//bool andbool3 = a && (b == c) || (c < b);
//bool andbool4 = a && ((b == c) || (c < b));
//int d = 0;

//bool a = false;
//int b = 40;
//int c = 20;
//bool d = true;
//int e = 0;

//bool vysledok = ((c <= b) || !a) && (a == (e == b));
//Console.WriteLine(vysledok);

//string number;
//number = Console.ReadLine();
//int n = int.Parse(number);
//if (n >= 1 && n <= 6)
//{
//    Console.WriteLine("máš kocku");
//}
//else
//{
//    Console.WriteLine("daj mi kocku");
//}



Console.WriteLine("Zadaj čislo");
string? prveCislo = Console.ReadLine();
Console.WriteLine("Zadaj Operator (+, -, *, /, %)");
string oper = Console.ReadLine();
Console.WriteLine("Zadaj čislo");
string? druheCislo = Console.ReadLine();
double n1 = double.Parse(prveCislo);
double n2 = double.Parse(druheCislo);
double sucet = 0;
if (oper == "+")
{
    sucet = n1 + n2;
}
else if (oper == "-")
{
    sucet = n1 - n2;
}
else if (oper == "*")
{
    sucet = n1 * n2;
}
else if (oper == "/")
{
    sucet = n1 / n2;
}
else if (oper == "%")
{
    sucet = n1 % n2;
}
else
{
    Console.WriteLine("Neplatna operacia!");
    return;
}

Console.WriteLine($"Vysledok: {sucet}");