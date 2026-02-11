namespace bergninger_med_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("=======================matador=======================");
            Random Terning = new Random();
            int kastnr1 = Terning.Next(1, 7);
            int kastnr2 = Terning.Next(1, 7);

            int sum = kastnr1 + kastnr2;


            Console.WriteLine($"Dit første terning slog: {kastnr1}");
            Console.WriteLine($"Dit Næste terning slog: {kastnr2}"); 
            Console.WriteLine($"Den samlede værdig er din terninger er: {sum}");

            bool doublebonus = kastnr1 == kastnr2;


            Console.WriteLine($"Ryk nu {sum} felter frem, hvis du passere start for du 4000kr");
            Console.WriteLine($"er der dobbelt bonus på slaget? {doublebonus}");





           




        }

    }
}
