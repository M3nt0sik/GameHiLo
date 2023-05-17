using GameHiLo;

internal class Program
{
    
    private static void Main(string[] args)
    {
        Console.WriteLine("Witaj w HiLo!");
        Console.WriteLine($"Odgadnij liczbe do {HiLoGame.MAXIMUM}.");
        HiLoGame.Hint();
        while (HiLoGame.GetPot() > 0)
        {
            Console.WriteLine("Wcisnij w (wieksza), m (mniejsza) lub ? (kupno wskazowki).");
            Console.WriteLine($"Inne klawisze to koniec gry z {HiLoGame.GetPot()} zl.");
            char key = Console.ReadKey(true).KeyChar;
            if (key == 'w') HiLoGame.Guess(true);
            else if (key == 'm') HiLoGame.Guess(false);
            else if (key == '?') HiLoGame.Hint();
            else return;
        }
        Console.WriteLine("Skonczyly ci sie pieniadze. Do zobaczenia!");
    }
}