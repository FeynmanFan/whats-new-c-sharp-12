namespace ConsoleApp1
{
    public class RocketC(string model, int engineCount) : Rocket(model, engineCount)
    {
        public int MaxCrew { get; set; }
    }
}
