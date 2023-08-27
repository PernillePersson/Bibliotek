namespace Bibliotek;

public class Bog
{
    public int Id { get; set; }
    public string Titel { get; set; } = null!;
    public int År { get; set; }
    public string Forlag { get; set; }
    public bool Udlånt { get; set; }
    
}