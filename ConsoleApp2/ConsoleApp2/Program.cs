namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Back.Hello("salih");
            Console.WriteLine("completed");
            Myconstructor my = new Myconstructor("salih");
            string greet=my.Message();
            Myname name = new Myname("salih");
            Console.WriteLine(name.Message());
        }

    }
    public static class Back
    {
        public static void Hello(string message)
        {
            Console.WriteLine(message);

        }
    }
    public class Myconstructor
    {
        string  message;
        public Myconstructor(string message)
        {
            this.message=message;
        }
        public string Message()
        {
            return "hello"+message;
        }
    }
    public class Myname : Myconstructor
    {
        string name;
        public Myname(string message) : base(message)
        {
            this.name=message;
        }
        public string Message()
        {
            return "hello  "+name;
        }
    }
}
