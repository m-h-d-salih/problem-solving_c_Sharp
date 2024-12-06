namespace leetcode3289
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSneakyNumbers([0,1,1,0]));
        }
        public static int[] GetSneakyNumbers(int[] nums)
        {
            List<int> result = new List<int>(); 

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < nums.Length; j++) 
                {
                    if (nums[i] == nums[j] && i != j) 
                    {
                        count++;
                    }
                }
                if (count == 1) 
                {
                    if (!result.Contains(nums[i])) 
                    {
                        result.Add(nums[i]);
                    }
                }
            }

            return result.ToArray();
        }
    }
}
