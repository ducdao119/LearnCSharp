namespace LearnCSharp.Day5
{
    public class Alarm
    {
        public event EventHandler OnAlarm;
        public void Trigger()
        {
            OnAlarm?.Invoke(this, EventArgs.Empty);
        }
    }
}
