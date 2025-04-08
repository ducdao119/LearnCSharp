using System.Runtime.CompilerServices;

namespace LearnCSharp.Day3
{
    public delegate void MyDelegate(string message);
    public delegate int SampleDelegate(int a, int b);
    public static class Delegate
    {
        public static void HandleDelegate()
        {
            //MyDelegate myDelegate = ShowMessageDelegate;
            //myDelegate("Hello world!");
            //ActionDelegate();
            //FuncDelegate();
            //PredicateDelegate();
            HandleSampleDelegate();
        }

        private static void HandleSampleDelegate()
        {
            Console.WriteLine("This is a sample delegate");
            SampleDelegate sampleDelegate;
            sampleDelegate = Add;
            Console.WriteLine($"Add function {sampleDelegate(3, 4)}");
            Predicate<int> isCheckEvenNumbers = (a) => a % 2 == 0;

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var item in numbers)
            {
                if(isCheckEvenNumbers(item))
                {
                    Console.WriteLine($"{item} is even number");
                }
                else
                {
                    Console.WriteLine($"{item} is odd number");
                }
            }
        }
        private static int Add(int a, int b) => a + b;

        private static void ShowMessageDelegate(string msg)
        {
            Console.WriteLine($"This is a sample delegate {msg}");
            Console.WriteLine();
        }

        /// <summary>
        /// Action is a delegate that can take a method with a void return type and any number of parameters.
        /// The Maximum number of parameters is 16.
        /// </summary>
        private static void ActionDelegate()
        {
            MyDelegate myDelegate = ShowMessageDelegate;
            Action<string> log;
            log = msg => myDelegate(msg);
            log += msg => Console.WriteLine("Hello world");
            Console.WriteLine($"This is action delegate");
            log("Hello world!");

            Action<List<int>, int> logInt = (list, a) =>
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item + a);
                }
            };

            logInt(new List<int> { 1, 2, 3, 4, 5 }, 9);
        }

        /// <summary>
        /// Func is a delegate that can take a method with a return type and any number of parameters.
        /// The Maximum number of parameters is 16.
        /// 15 parameters are used for the input and the last one is used for the return type.
        /// </summary>
        private static void FuncDelegate()
        {
            Console.WriteLine("This is Func delegate");
            Func<int, int, int, string> func = (a, b, c) =>
            {
                return $"The sum of {a}, {b}, and {c} is {a + b + c}";
            };
            Console.WriteLine(func(1, 2, 3));
        }

        /// <summary>
        /// Predicate is a delegate that can take a method with a return type of bool and any number of parameters.
        /// The maximum number of parameters is 1.
        /// </summary>
        private static void PredicateDelegate()
        {
            Console.WriteLine("This is Predicate delegate");
            Predicate<int> isEven = (a) =>
            {
                return a % 2 == 0;
            };
            Console.WriteLine(isEven(5));
        }
    }
}
