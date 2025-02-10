namespace arrayMMethhods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5, };
            Array myArray=Array.CreateInstance(typeof(int),5);
            foreach(int i in myArray)
            {
                Console.WriteLine(i);
            }  
        }
    }
}
