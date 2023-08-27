namespace Bibliotek;

public class FileReader
{
    public void ReadBøger()
    {
        var text = File.ReadAllText("bøger.json");
        Console.WriteLine(text);
    }
    
    public void ReadLåner()
    {
        var text = File.ReadAllText("låner.json");
        Console.WriteLine(text);
    }

}