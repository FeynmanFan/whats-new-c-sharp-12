namespace ConsoleApp1
{
    public class RocketA(string model, int engineCount) : Rocket(model, engineCount)
    {
        public int StageCount { get; set; }
    }
}
