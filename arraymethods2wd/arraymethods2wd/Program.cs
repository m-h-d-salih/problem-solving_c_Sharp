namespace arraymethods2wd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= { 11, 2, 13 ,4};
            string[] s = { "hello", "hii", "abs", "bn" }; 
            foreach (string i in s) { 
            Console.WriteLine(i);
            }
            Array.Sort(s);
            foreach (string i in s)
            {
                Console.WriteLine(i);
            }
        }
    }
}
