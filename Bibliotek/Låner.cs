namespace Bibliotek;

public class Låner
{
    public int id { get; set; }
    public String navn { get; set; }
    public String adresse { get; set; }
    public float tlf { get; set; }
    public List<Bog> lånt { get; set; }
}