namespace _7__2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 710, 40, 800, 120, 650, 500 };
            arr.PrintReverse();
            Console.WriteLine(arr.GetFirstElement());
            Console.WriteLine(arr.GetLastElement());
            Console.WriteLine(arr.ContainsElement(530));
            Console.WriteLine(arr.CountElements());
            Console.WriteLine(arr.FindIndex());
        }
    }
}
