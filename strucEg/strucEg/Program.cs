namespace strucEg
{
    internal class Program
    {
        struct Student
        {
            public int Id;
            public string Name;
        }
        static void Main(string[] args)
        {
            Student student;
            student.Id = 10;
            student.Name = 10+" ejdcnewj";
            Console.WriteLine(student.Name);
            object obj = student.Name;
            Console.WriteLine(obj);
            string hello = "hello";
            hello = "j";      
            Console.WriteLine(hello);
        }
    }
}
