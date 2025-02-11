namespace hashset
{
    internal class Program
    {
        static void Main(string[] args)
        {
           HashSet<string> set = new HashSet<string>() { "salih","salih","fasal"};
            Console.WriteLine(String.Join(", ",set));
            set.Add("priya");
            Console.WriteLine(String.Join(", ", set));
            set.Clear();
            Console.WriteLine(String.Join(", ", set)+" empty");

        }
    }
}
