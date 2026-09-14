namespace _11_Skatteuträknaren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            int b = 100;

            try
            {
                int c = checked(a + b);
                Console.WriteLine($"{c}");
            }
            catch (OverflowException) { Console.WriteLine("Overflow! talet är för stort"); }
            try
            {
                int u = unchecked(a + b);
                Console.WriteLine($"{u}");
            }
            catch(OverflowException) { Console.WriteLine("Overflow! talet är för stort");}

            Console.ReadKey();
        }
    }
}
