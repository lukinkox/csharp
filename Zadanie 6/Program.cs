using Zadanie_6;

class Program
{
    static void Main(string[] args)
    {
        Kviz kviz = new Kviz();

        string cesta = @"C:\\Users\\Lukas\\Desktop\\Textovy dokumnet\\Domaca uloha kviz otazky\\";

        kviz.NacitajOtazky(cesta);
        kviz.SpustiKviz();

        Console.WriteLine("Ukoncenie Kvizu");
    }
}