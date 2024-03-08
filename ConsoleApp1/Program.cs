namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var monster = new RocketA("Monster", 16) { StageCount = 3 };
            var mini = new RocketB("Mini", 2) { MaxPayload = 1000 };
            var dragon = new RocketA("Dragon", 12) { StageCount = 2 };
            var wombat = new RocketB("Wombat", 3) { MaxPayload = 1000 };
            var eagle = new RocketC("Eagle", 8) { MaxCrew = 3 };
            var dragonfly = new RocketC("Dragonfly", 12) { MaxCrew = 10 };

            var multistage = new List<Rocket> { monster, dragon };

            List<Rocket> payload = new() { mini, wombat };

            List<Rocket> crew = [eagle, dragonfly];

            List<Rocket> allRockets = [.. multistage, .. payload, .. crew];

            foreach (var rocket in pasteCollectionsIterate(payload, crew))
            {
                Console.WriteLine(rocket.Model);
            }

            foreach (var rocket in pasteCollectionsUnion(payload, crew))
            {
                Console.WriteLine(rocket.Model);
            }
            foreach (var rocket in allRockets)
            {
                Console.WriteLine(rocket.Model);
            }
        }

        public static List<Rocket> pasteCollectionsIterate(List<Rocket> collectionA, List<Rocket> collectionB)
        {
            var collection = new List<Rocket>();

            foreach (var rocket in collectionA)
            {
                collection.Add(rocket);
            }

            foreach(var rocket in collectionB)
            {
                collection.Add(rocket);
            }

            return collection;
        }

        public static List<Rocket> pasteCollectionsUnion(List<Rocket> collectionA, List<Rocket> collectionB)
        {
            return collectionA.Union<Rocket>(collectionB).ToList();
        }
    }
}
