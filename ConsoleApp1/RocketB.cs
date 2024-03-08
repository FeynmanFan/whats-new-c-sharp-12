namespace ConsoleApp1
{
    public class RocketB(string model, int engineCount) : Rocket(model, engineCount)
    {
        public int MaxPayload {  get; set; }
    }
}
