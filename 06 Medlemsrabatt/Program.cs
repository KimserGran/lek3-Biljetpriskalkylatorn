namespace _06_Medlemsrabatt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Guldmedlem;
            int ålder;
            decimal kostnad;
            decimal prisRabatt = 500;

            Console.WriteLine($"Välkommen! är du guldmedlem? (ja/nej)");
            string svar = Console.ReadLine().ToLower();
            Guldmedlem = svar == "ja" ? true : false;

            Console.WriteLine("Hur gammal är du?");
            ålder = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur mycket har du handlat för?");
            kostnad = decimal.Parse(Console.ReadLine());

            if(Guldmedlem || kostnad >= prisRabatt || ålder >= 65)
                Console.WriteLine("Du är berättigad 10% rabatt på ditt köp!");

            Console.ReadKey();
        }
    }
}
