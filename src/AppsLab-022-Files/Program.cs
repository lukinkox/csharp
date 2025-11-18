
string text = Console.ReadLine();
//File.WriteAllText("C:\\Users\\Lukas\\Desktop\\Textovy dokumnet\\text.txt", text);
while (true)
{
    text = Console.ReadLine();
    if (text == "koniec")
        break;

    File.AppendAllText("C:\\Users\\Lukas\\Desktop\\Textovy dokumnet\\text.txt", text + Environment.NewLine);
}

string textzoSuboru = File.ReadAllText(text);
Console.WriteLine(textzoSuboru);
