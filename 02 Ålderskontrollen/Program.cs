namespace _02_Ålderskontrollen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange din ålder:");
            int ålder = int.TryParse(Console.ReadLine(), out var parsedValue) ? parsedValue : 0;
            bool ärMyndig = ålder >= 18;
            if(ärMyndig)
            {
                Console.WriteLine("Du är myndig.");
            }
            else
            {
                Console.WriteLine("Du är inte myndig.");
            }
        }
    }
}
