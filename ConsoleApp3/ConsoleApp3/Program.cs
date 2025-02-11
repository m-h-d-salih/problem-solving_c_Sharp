using System.Reflection.Emit;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            bool b=false;
            if(b)
            goto label1;
            else goto label2;
            label1:
            Console.WriteLine("label 1");
            label2:
            Console.WriteLine("label 2");
            Console.WriteLine("end");
        }
    }
}
