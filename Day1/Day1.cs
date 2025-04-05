using LearnCSharp.Models;

namespace LearnCSharp
{
    public static class Day1
    {
        public static void TypeData()
        {
            HandleValueType();
            HandleReferenceType();
            HandleBoxingUboxing();
        }

        /// <summary>
        /// Boxing and Uboxing in C#
        /// Boxing is the process of converting a value type to a reference type.
        /// Uboxing is the precess of converting a reference type back to a value type.
        /// When Boxing, you should use Sparingly, as it can lead to performance issues.
        /// </summary>
        private static void HandleBoxingUboxing()
        {
            int a = 1;
            object b = a; //Boxing
            int c = (int)b; //Unboxing
            a = 2;
            Console.WriteLine("Boxing and Unboxing:");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b - Boxing: {b}");
            Console.WriteLine($"c - Unboxing: {c}");
            Console.WriteLine();
        }

        /// <summary>
        /// Reference Type in C#
        /// Value storage in heap
        /// Address storage in stack
        /// When you assign a reference type to another variable, you are copying the address of the object, not the object itself.
        /// </summary>
        private static void HandleReferenceType()
        {
            Person person1 = new Person();
            person1.Name = "John";
            Person person2 = person1;
            person2.Name = "Doe";
            Console.WriteLine("Reference Type:");
            Console.WriteLine($"person1: {person1.Name}");
            Console.WriteLine($"person2: {person2.Name}");
            Console.WriteLine();
        }

        /// <summary>
        /// Value Type in C#
        /// Value and Address storage in stack
        /// When you assign a value type to another variable, you are copying the value, not the address.
        /// </summary>
        private static void HandleValueType()
        {
            int a = 1;
            int b = a;
            b = 2;
            Console.WriteLine("Value Type:");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine();
        }
    }
}
