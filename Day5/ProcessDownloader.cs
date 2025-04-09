namespace LearnCSharp.Day5
{
    public class ProcessDownloader
    {
        public event EventHandler<Downloader> PregessChanged;

        public void StartDownloadAsync()
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(50);
                OnProgressChanged(i);
            }
        }

        protected virtual void OnProgressChanged(int i)
        {
            PregessChanged?.Invoke(this, new Downloader { Percent = i });
        }
    }
}
