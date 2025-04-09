using System.Threading.Channels;

namespace LearnCSharp.Day5
{
    public static class EventHandlerSample
    {
        public static void EventHandlerEx()
        {
            //ButtonEvent btn = new ButtonEvent();
            //btn.OnClick += msg => Console.WriteLine(msg);
            //btn.Click();

            //var alarm = new Alarm();
            //alarm.OnAlarm += (sender, args) => Console.WriteLine("Alarm triggered!");
            //alarm.Trigger();

            //var sensor = new Sensor();
            //sensor.DataRecieved += (sender, e) => Console.WriteLine($"Sensor data received: {e.Value}");
            //sensor.EmmitData(10);

            //var counter = new Counter(6);
            //counter.ThresholdReached += (sender, e) =>
            //{
            //    Console.WriteLine($"Threshold reached: {e.Threshold} at {e.TimeReached}");
            //};

            //while (true)
            //{
            //    Console.Write("Nhập số cần cộng (hoặc q để thoát): ");
            //    var input = Console.ReadLine();
            //    if(input == "q")
            //    {
            //        break;
            //    }
            //    if(int.TryParse(input, out int value))
            //    {
            //        counter.Add(value);
            //    }
            //}

            var downloader = new ProcessDownloader();
            downloader.PregessChanged += (sender, e) =>
            {
                Console.WriteLine($"Dowloading: {e.Percent}%");
            };

            Console.WriteLine("Bắt đầu tải file...");
            downloader.StartDownloadAsync();
            Console.WriteLine("✅ Tải xong!");
        }
    }
}
