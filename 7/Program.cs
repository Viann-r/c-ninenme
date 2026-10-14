namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 80, 40, 530, 810, 340, 600 };
            nums.PrintReverse();
            Console.WriteLine(nums.GetFirstElement());
            Console.WriteLine(nums.GetLastElement());
            Console.WriteLine(nums.ContainsElement(530));
            Console.WriteLine(nums.CountElements());
            Console.WriteLine(nums.FindIndex());

        }
    }
}
