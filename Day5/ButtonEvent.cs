namespace LearnCSharp.Day5
{
    public class ButtonEvent
    {
        public delegate void ClickHandle(string message);
        public event ClickHandle OnClick;

        public void Click()
        {
            if(OnClick != null)
            {
                OnClick("Button clicked!");
            }
        }
    }
}
