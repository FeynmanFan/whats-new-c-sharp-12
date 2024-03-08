namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var monster = new RocketA("Monster", 16);
            var mini = new RocketB("Mini", 2);
            var dragon = new RocketA("Dragon", 12);
            var wombat = new RocketB("Wombat", 3);

            var rocketsA = new List<RocketA> { monster, dragon };

            List<RocketA> rocketsA2 = new() { monster, dragon };

            List<RocketB> rocketsB = [mini, wombat];


            foreach (RocketA rocket in rocketsA)
            {
                Console.WriteLine(rocket.ToString());
            }

            foreach (RocketA rocket in rocketsA2)
            {
                Console.WriteLine(rocket.ToString());
            }

            foreach (RocketB rocket in rocketsB)
            {
                Console.WriteLine(rocket.ToString());
            }

        }
    }
}
