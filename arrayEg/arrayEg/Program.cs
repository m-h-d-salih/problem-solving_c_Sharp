namespace arrayEg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size of the arra");
            int n=int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i < a.Length; i++)
            {
                a[i]=int.Parse(Console.ReadLine());
            }
            for(int i = 0;i < a.Length; i++)
            {
                Console.WriteLine(a[i]);    
            }
            string[] b = { "bugatti", "pagani" };
            foreach(string i  in b)
            {
                Console.WriteLine(i);
            }
            var s = b.Where(n => n == "bugatti");
            Console.WriteLine(string.Join(", ",s));
            var s1 = b.FirstOrDefault(n => n == "pagani");
            Console.WriteLine(s1);
        }
    }
}
