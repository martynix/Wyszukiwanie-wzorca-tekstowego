using System;

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
        Console.WriteLine();
        Console.Write("Podaj test: ");
        test = Console.ReadLine();
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
        }
        else
        {
            do
            {
                Console.WriteLine($"Wzorzec występuje na pozycji: {pozycja}");
                pozycja = test.IndexOf(wzorzec, pozycja + 1, StringComparison.OrdinalIgnoreCase);
            } while (pozycja != -1);
        }
    }
}

class WyszukiwanieRozszerzone : WyszukiwanieBaza
{
    public void DodajPrefiks(string prefiks)
    {
        wzorzec = prefiks + wzorzec;
    }
}

class Program
{
    static void Main()
    {
        WyszukiwanieRozszerzone wyszukiwanie = new WyszukiwanieRozszerzone();

        wyszukiwanie.PodajWzorzec();
        wyszukiwanie.PodajTest();
        wyszukiwanie.DodajPrefiks("Słowo: ");
        wyszukiwanie.SprawdzDlugoscTestu();
        wyszukiwanie.WyszukajWzorzec();

        Console.ReadLine();
    }
}

}