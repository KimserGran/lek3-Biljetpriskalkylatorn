namespace _03_Inloggningsvalidering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string korrektAnvändarnamn = "admin";
            const string korrektLösenord = "password";

            Console.WriteLine("Skriv ditt användarnamn:");
            string användarnamn = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Skriv ditt lösenord:");
            string lösenord = Console.ReadLine();

            Console.Clear();
            bool inloggad = användarnamn == korrektAnvändarnamn && lösenord == korrektLösenord;
            if (inloggad == true)
                            {
                Console.WriteLine("Inloggning lyckad!");
            }
            else
            {
                Console.WriteLine("Fel användarnamn eller lösenord.");
            }

            Console.ReadKey();
        }
    }
}
