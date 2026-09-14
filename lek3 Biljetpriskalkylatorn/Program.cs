using System.Threading.Channels;

namespace lek3_Biljetpriskalkylatorn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal grundPris = 120;
            Console.WriteLine("Hur många biljetter vill du köpa?");
            int köptaBiljetter = int.TryParse(Console.ReadLine(), out var parsedValue) ? parsedValue : 0;
            decimal totalPris = grundPris * köptaBiljetter;
            decimal rabatt = 0.9m;
            if (köptaBiljetter >= 3)
            {
                Console.WriteLine($"Totala priset är: {totalPris * rabatt} kr (10% rabatt)");
            }
            else
            {
                Console.WriteLine($"Totala priset är: {totalPris} kr");
            }
        }
    }
}
