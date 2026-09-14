namespace _09_Inkrementeingstjusa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;

            Console.WriteLine($" ++a lägger till innan värdet är läst: {a} ++: {++a} {a} \n b++ lägger till efter värdet är läst: {b} b++: {b++} {b}");
            Console.ReadKey();
        }
    }
}
