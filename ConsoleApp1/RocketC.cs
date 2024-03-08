namespace ConsoleApp1
{
    public class RocketC
    {
        private RocketC() { }

        public static RocketC Create(string model, int engineCount)
        {
            return new RocketC { Model = model, EngineCount = engineCount };
        }

        public string Model { get; set; }
        public int EngineCount { get; set; }
    }
}
