namespace hashset
{
    internal class Program
    {
        static void Main(string[] args)
        {
           HashSet<string> set = new HashSet<string>() { "salih","salih","fasal"};
            List<int> list = new List<int>() { 1,2};
            Console.WriteLine(String.Join(", ",set));
            set.Add("priya");
            Console.WriteLine(String.Join(", ", set));
            
            Console.WriteLine(String.Join(", ", set)+" empty");
            Dictionary<int,string> d=new Dictionary<int, string>();
            for(int i = 0; i < set.Count; i++)
            {
                d.Add(list[i], set.ElementAt(i));
            }
            Console.WriteLine(String.Join(", ",d));
            set.Clear();
        }
    }
}
 