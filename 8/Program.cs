namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 30, 5, 800, 400, 10, 250, 80 };
            nums.Where((int num) => num > 20);
            foreach (int num in nums)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();
            Console.WriteLine(nums.FirstOrDefault((int num) => num > 100));
            Console.WriteLine(nums.Any((int num) => num > 20));
            Console.WriteLine(nums.All((int num) => num > 0));
            Console.WriteLine(nums.Count((int num) => num > 200));
        }
    }


}
