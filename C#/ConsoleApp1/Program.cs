class WyszukiwanieBaza
{
    protected string wzorzec;
    protected string test;

    public virtual void PodajWzorzec()
    {
        Console.Write("Podaj wzorzec: ");
        wzorzec = Console.ReadLine();
    }

    public virtual void PodajTest()
    {
        Console.Write("Podaj test: ");
        test = Console.ReadLine();
    }

    public virtual void DodajPrefiks()
    {
        Console.Write("Podaj prefiks: ");
        string prefiks = Console.ReadLine();
        test = prefiks + test;

        Console.WriteLine($"Zmodyfikowane słowo: {test}");
    }

    public virtual void SprawdzDlugoscTestu()
    {
        while (wzorzec.Length > test.Length)
        {
            Console.WriteLine("Test powinien być dłuższy niż wzorzec!");
            Console.WriteLine();
            PodajTest();
        }
    }

    public virtual void WyszukajWzorzec()
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
                Console.WriteLine($"Wzorzec występuje na pozycji: {pozycja+1}");
                pozycja = test.IndexOf(wzorzec, pozycja + 1, StringComparison.OrdinalIgnoreCase);
            } while (pozycja != -1);
            Console.WriteLine();

        }
    }
}

class Program
{
    static void Main()
    {
        WyszukiwanieBaza wyszukiwanie = new WyszukiwanieBaza();

        while (true)
        {
            wyszukiwanie.PodajWzorzec();
            wyszukiwanie.PodajTest();
            wyszukiwanie.DodajPrefiks();
            wyszukiwanie.SprawdzDlugoscTestu();
            wyszukiwanie.WyszukajWzorzec();

            Console.WriteLine("Naciśnij Enter, aby kontynuować...");
            Console.ReadLine();
        }
    }
}
