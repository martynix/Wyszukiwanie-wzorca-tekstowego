class WyszukiwanieBaza
{
    protected string wzorzec;  // Protected - dostęp jest ograniczony do zawierającej klasy lub typów pochodzących z zawierającej klasy.
    protected string test;

    public void PodajWzorzec()  // Public - dostęp nieograniczony, kod jest dostępny dla wszystkich klas
    {
        Console.Write("Podaj wzorzec: ");
        wzorzec = Console.ReadLine();
    }

    public void PodajTest()
    {
        Console.Write("Podaj test: ");
        test = Console.ReadLine();
    }

    public void SprawdzDlugoscTestu()
    {
        while (wzorzec.Length > test.Length)
        {
            Console.WriteLine("Test powinien być dłuższy niż wzorzec!");
            Console.WriteLine();
            PodajTest();
        }
    }

    public void WyszukajWzorzec()
    {
        int pozycja = test.IndexOf(wzorzec, StringComparison.OrdinalIgnoreCase);

        if (pozycja == -1)
        {
            Console.WriteLine("Nie znaleziono wzorca w tekście");
            Console.WriteLine();
        }
        else
        {
            do
            {
                Console.WriteLine($"Wzorzec występuje na pozycji: {pozycja + 1}");
                pozycja = test.IndexOf(wzorzec, pozycja + 1, StringComparison.OrdinalIgnoreCase);
            } while (pozycja != -1);
            Console.WriteLine();
        }
    }
}

class WyszukiwanieZPrefiksem : WyszukiwanieBaza
{
    public new void DodajPrefiks()
    {
        Console.Write("Podaj prefiks: ");
        string prefiks = Console.ReadLine();
        test = prefiks + test;

        Console.WriteLine($"Zmodyfikowane słowo: {test}");
        SprawdzDlugoscTestu(); // Dodane sprawdzenie długości po dodaniu prefiksu
    }
}

class Program
{
    static void Main()
    {
        WyszukiwanieZPrefiksem wyszukiwanie = new WyszukiwanieZPrefiksem();

        while (true)
        {
            wyszukiwanie.PodajWzorzec();
            wyszukiwanie.PodajTest();
            wyszukiwanie.DodajPrefiks(); // Używamy nadpisanej metody z dziedziczenia
            wyszukiwanie.WyszukajWzorzec();

            Console.WriteLine("Naciśnij Enter, aby kontynuować...");
            Console.ReadLine();
        }
    }
}
