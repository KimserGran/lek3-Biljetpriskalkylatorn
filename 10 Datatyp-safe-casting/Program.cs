namespace _10_Datatyp_safe_casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object input = "123";
            string? text = input as string ?? "null";
            object input2 = 123;
            string? text2 = input2 as string ?? "null";
            Console.WriteLine(text);
            Console.WriteLine(text2);
            Console.ReadKey();

            
        }
    }
}
