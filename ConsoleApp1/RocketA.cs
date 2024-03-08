namespace ConsoleApp1
{
    public class RocketA
    {
        private string _model;
        private int _engineCount;

        public RocketA(string model, int engineCount)
        {
            this._model = model;
            this._engineCount = engineCount;
        }

        public string Model 
        {  
            get 
            { 
                return _model; 
            } 
        }

        public int EngineCount 
        { 
            get 
            { 
                return _engineCount; 
            } 
        }
    }
}
