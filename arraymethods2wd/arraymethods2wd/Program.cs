namespace arraymethods2wd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= { 11, 2, 13 ,4};
            foreach (int i in arr) { 
            Console.WriteLine(i);
            }
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
