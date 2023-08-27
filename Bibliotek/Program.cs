namespace Bibliotek;



public class Program
{
    
    public void WriteFiles()
    {
        FileReader fn = new FileReader();
        fn.ReadLåner();
        fn.ReadBøger();
        
        

        /*new Bog()
        {
            Id = 1,
            Titel = "Hej",
            År = 2023,
            Forlag = "Mojn",
            Udlånt = false
        };*/
    }

    
}