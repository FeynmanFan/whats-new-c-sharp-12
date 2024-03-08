namespace ConsoleApp1
{
    public abstract class Rocket(string model, int engineCount)
    {
        public string Model => model;
        public int EngineCount => engineCount;
    }
}
