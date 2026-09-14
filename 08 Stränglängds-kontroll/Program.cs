namespace _08_Stränglängds_kontroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? text = null;
            Console.WriteLine(text == null ? "Strängens längd är 0" : $"Stränglängd: {text?.Length}");
            Console.ReadKey();  
        }
    }
}
