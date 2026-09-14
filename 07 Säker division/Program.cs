namespace _07_Säker_division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en täljare:");
            if (!double.TryParse(Console.ReadLine(), out double a) || a == 0)
            {
                Console.WriteLine("Täljaren måste vara större än 0.");
                Console.ReadKey();
                return;
            }
            double täljare = a;

            Console.WriteLine("Skriv en nämnare:");
            if (!double.TryParse(Console.ReadLine(), out double b) || b == 0)
            {
                Console.WriteLine("Nämnaren måste vara större än 0.");
                Console.ReadKey();
                return;
            }
            double nämnare = b;

            Console.WriteLine(nämnare != 0 
                ? $"Resultatet av {täljare} / {nämnare} är: {(double)täljare / nämnare}" 
                : "Division med noll är inte tillåten.");
            Console.ReadKey();
        }
    }
}
