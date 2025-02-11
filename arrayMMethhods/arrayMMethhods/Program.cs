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

            string s = "hello";
            s = "h";
            Console.WriteLine(s);
            Console.Beep();
            int dec = 10;
            int bin=0b10;
            int hexx = 0X12f;
            Console.WriteLine($"decimal = {dec} binary = {bin} hexadecimal = {hexx}");
            double a = 10.15; //By Default Floating Point Literal is double
            //Float Literal
            float b = 100.72F; //Suffix with F
            //Double Literal
            double c = 1.45D; //Suffix with D
            //Decimal Literal
            decimal d = 1.44M; //Suffix with M

            Console.WriteLine($"Double Literal: {a}");
            Console.WriteLine($"Float Literal: {b}");
            Console.WriteLine($"Double Literal: {c}");
            Console.WriteLine($"Decimal Literal: {d}");
            Console.WriteLine("hloo \n how are \t u");
            Console.WriteLine(@"helllo \n how are \t u");
            Console.ReadKey();
        }
    }
}
