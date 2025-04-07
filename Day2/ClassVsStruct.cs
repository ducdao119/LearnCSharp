namespace LearnCSharp.Day2
{
    /// <summary>
    /// Class is reference type
    /// </summary>
    public class ClassVsStruct
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public ClassVsStruct(string name, string type, int age)
        {
            this.Name = name;
            this.Type = type;
            this.Age = age;
        }
    }

    /// <summary>
    /// Struct is value type
    /// </summary>
    public struct Size
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string Type { get; set; }

        public Size(int height, int width, string type)
        {
            this.Height = height;
            this.Width = width;
            this.Type = type;
        }
    }
}
