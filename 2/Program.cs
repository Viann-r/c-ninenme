namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car horch = new Car { Brand = "Cabriolet", Model = "Horch 853 Voll & Ruhrbek Sport Cabriolet", Year = 1937, Engine = "4944", Color = "Black" };
            horch.DisplayInfo();
        }
    }
}
