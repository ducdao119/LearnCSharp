namespace LearnCSharp.DesignPattern.Singleton
{
    internal class SingletonSample
    {
        private SingletonSample() { }
        private static SingletonSample _instance;
        private static readonly object _lock = new object();
        public static SingletonSample GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonSample();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }

        public string Value { get; set; }
    }
}
