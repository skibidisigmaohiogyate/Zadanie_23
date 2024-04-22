using ConsoleApp1;

class PlikGlowny
{
    static void Main(string[] args)
    {
        Tablica tablica = new Tablica();

        int[] tab = tablica.Tworzenie_tablicy();

        for (int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }
  
}