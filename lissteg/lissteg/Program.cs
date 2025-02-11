namespace lissteg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<int> list1 = new List<int>();
            list.Add("salih");
            list.Add("fasal");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Remove("fasal");
            Console.WriteLine(String.Join(", ", list));
            for(int i = 1; i < 3; i++)
            {
                list1.Add(i);
            }
            Console.WriteLine(list1.Contains(2));
            list.Union(list);
            Console.WriteLine(String.Join(',',list));

            
        }
    }
}
