namespace LearnCSharp.Day4
{
    public static class LinQ
    {
        static List<Person> persons = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 },
            new Person { Name = "Charlie", Age = 30 }
        };

        public static void HandleLinQ()
        {
            var grouped = persons.GroupBy(p => p.Age);
            foreach (var group in grouped)
            {
                Console.WriteLine($"Age: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine($" - {person.Name}");
                }
            }
        }
    }
}
