namespace ConsoleApp1
{
    public abstract class Rocket(string model, int engineCount)
    {
        public string Model => model;
        public int EngineCount => engineCount;

        readonly Func<double, double, double> calculateTimeToFall = (double height, double g = 9.8) =>
        {
            return Math.Sqrt((2 * height) / g);
        };

        Func<double, double, double> calculateConstantSpeed = (double distance, double speed) =>
        {
            if (speed == 0)
            {
                throw new ArgumentException("Speed cannot be zero.");
            }

            return distance / speed;
        };
    }
}
