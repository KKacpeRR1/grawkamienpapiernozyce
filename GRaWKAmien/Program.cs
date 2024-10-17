class SUPERGRA
{
    static void Main(String[] args)
    {
        Random rnd = new Random();
        int wybor_komputera = rnd.Next(3);
        int wybor = int.Parse(Console.ReadLine());
        if (wybor == 0)
        {
            Console.WriteLine("Wybierz 1, 2 albo 3.");
            wybor = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Wybierz (1) papier, (2) kamien, (3) nozyce, lub (0) zeby wyjsc");
        switch (wybor)
        {
            case 1:
                break;
            {
            
            }
            
        }
    }        
}