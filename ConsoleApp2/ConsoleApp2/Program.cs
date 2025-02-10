namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Back.Hello("salih");
            Console.WriteLine("completed");
        }

    }
    public static class Back
    {
        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }
}
