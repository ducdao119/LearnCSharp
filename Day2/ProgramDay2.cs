namespace LearnCSharp.Day2
{
    public static class ProgramDay2
    {
        public static void HandleClassesVsStruct()
        {
            HandleClasses();
            HandleStruct();
        }
        /// <summary>
        /// When you assign new value of class, it will change data of relation class
        /// </summary>
        public static void HandleClasses()
        {
            ClassVsStruct c = new ClassVsStruct("Duc", "Nam", 12);
            ClassVsStruct b = c;
            b.Name = "Trung";
            Console.WriteLine("Class");
            Console.WriteLine(c.Name);
            //When you use keyword "defauult". with class the data is "null"
            ClassVsStruct d = default;
            //Console.WriteLine($"{d.Age}");
            Console.WriteLine();
        }
        /// <summary>
        /// When you assign new value of struct, it not effect data of relation struct
        /// </summary>
        public static void HandleStruct()
        {
            Size s = new Size(10, 20, "Nhua");
            Size z = s;
            z.Width = 1000;
            Console.WriteLine("Struct");
            Console.WriteLine(s.Width);
            Console.WriteLine(z.Width);
            Size w = default;
            Console.WriteLine($"{w.Width} {w.Height} {w.Type}");
            Console.WriteLine();
        }
    }
}
