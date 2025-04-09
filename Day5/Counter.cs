namespace LearnCSharp.Day5
{
    public class Counter
    {
        int count = 0;
        int threshold;

        public Counter(int threshold)
        {
            this.threshold = threshold;
        }

        public void Add(int x)
        {
            count += x;
            Console.WriteLine($"Count: {count}");
            if(count >= threshold)
            {
                HandleEventThres();
            }
        }

        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
        public void HandleEventThres()
        {
            ThresholdReached?.Invoke(this, new ThresholdReachedEventArgs { Threshold = count, TimeReached = DateTime.Now });
        }
    }
}
