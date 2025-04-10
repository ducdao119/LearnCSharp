﻿using LearnCSharp.Day2;
using LearnCSharp.Day3;
using LearnCSharp.Day4;
using LearnCSharp.Day5;
using LearnCSharp.DesignPattern.Singleton;

namespace LearnCSharp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Day1.TypeData();
            //ProgramDay2.HandleClassesVsStruct();
            //Day3.Delegate.HandleDelegate();
            //LinQ.HandleLinQ();
            //EventHandlerSample.EventHandlerEx();
            HandleSingleton();
        }

        private static void HandleSingleton()
        {
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

            Thread process1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });
            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        public static void TestSingleton(string value)
        {
            SingletonSample singleton = SingletonSample.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
