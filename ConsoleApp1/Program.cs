namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new RocketA("Monster", 16);
            var b = new RocketB("Mini", 2);

            Console.WriteLine($"{a.Model} has {a.EngineCount} engines");
            Console.WriteLine($"{b.Model} has {b.EngineCount} engines");
        }
    }
}
