namespace Bibliotek;

public class Låner
{
    public int Id { get; set; }
    public string Navn { get; set; }
    public string Adresse { get; set; }
    public float Tlf { get; set; }
    public List<Bog> Lånt { get; set; }
}