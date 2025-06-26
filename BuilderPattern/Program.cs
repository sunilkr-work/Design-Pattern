namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var student = new Student.StudentBuilder()
                .SetName("John Doe")
                .Build();
        }
    }
}
