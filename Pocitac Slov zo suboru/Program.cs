using Pocitac_Slov_zo_suboru;

static void Main(string[] args)
{
    Read reader = new Read();
    string content = reader.ReadFile();
    if (string.IsNullOrEmpty(content))
    {
        Console.WriteLine("Prazdny");
    }
    else
    {
        Count counter = new Count();
        int words = counter.PocitacSlov(content);
        Console.WriteLine("slova: " + words);
    }

}