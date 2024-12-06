namespace leetCode_167
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 7, 11, 15 };
            Console.WriteLine(string.Join(", ", TwoSum(arr, 9)));

        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            int left = 0, right = numbers.Length - 1;
            while (left < right)
            {
                int sum = numbers[left] + numbers[right];
                if (sum == target)
                {
                    return new int[] { left + 1, right + 1 }; ;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return Array.Empty<int>();
            ;
        }
    }
}

       


