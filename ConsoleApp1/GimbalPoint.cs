namespace ConsoleApp1
{
    [System.Runtime.CompilerServices.InlineArray(2)]
    struct GimbalPoint
    {
        int _;

        public override string ToString()
        {
            return "X: " + this[0] + "\nY: " + this[1];
        }
    }
}
