namespace _05_Implicit_vs_Explicit_Typkonvertering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tal = 500;
            double dubbel = tal;
            dubbel = 123.45;
            int nyttTal = (int)dubbel;

            Console.WriteLine($"int: {tal}\nint > dubbel(implicit): {dubbel}\n dubbel > int(explicit):{nyttTal}");
            Console.ReadKey();
        }
    }
}
