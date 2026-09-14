namespace _04_Godidelaren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int godisar = 23;
            int barn = 4;
            int godisPerBarn = godisar / barn;
            int överskott = godisar % barn;
            Console.WriteLine($"Varje barn får {godisPerBarn} godisar.");
            Console.WriteLine($"Det blir {överskott} godisar över.");
            Console.ReadKey();
        }
    }
}
