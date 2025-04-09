namespace LearnCSharp.Day5
{
    public class Sensor
    {
        public event EventHandler<DateEventArgs> DataRecieved;

        public void EmmitData(int val)
        {
            DataRecieved?.Invoke(this, new DateEventArgs { Value = val });
        }
    }
}
