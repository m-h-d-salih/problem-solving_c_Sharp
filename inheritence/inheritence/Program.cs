namespace inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Calculate    calculate = new Calculate();
            Console.WriteLine(calculate.sum(10));
            calculate.Hello();
            bool b = false;
            if (b)
            {
                Console.WriteLine("true");

            }else if (!b)
            {
                Console.WriteLine("false");
            }
        }
    }
    public interface Ihello
    {
        void Hello();
        int sum(int x);
    }
    public class Calculate:Ihello
    {
        public int sum(int x)
        {
            return x * 2;
        }
        public void Hello()
        {
            Console.WriteLine("COMPLETED");
        }
    }
}
