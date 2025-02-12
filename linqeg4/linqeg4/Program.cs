namespace linqeg4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6,7};
            var res=list.Where(x=>x%2==0);

            Console.WriteLine(String.Join(", ",res));
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            //query synntax
            var a = from n in numbers
                    where n % 2 == 0
                    select n;
            Console.WriteLine(String.Join(", ", a));
            int[] arr = { 1, 2, 3,4,5,6,7,8,9};
            list.Clear();
            foreach(int x in arr)
            {
                if(x%2==0)
                list.Add(x);
            }
            var sorted= list.OrderByDescending(x=>x);
            Console.WriteLine(String.Join(", ",sorted));
            var grouped=numbers.GroupBy(x=>x%2==0?"even":"odd");
            foreach(var x in grouped)
            {
                Console.WriteLine($"{x.Key} : {String.Join(", ",x)}");
            }
        }
    }
}
