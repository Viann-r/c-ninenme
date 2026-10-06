namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mochi ichigo = new Mochi { Flavor = "strawberry", Filling = "ice cream", Fruit = "strawberry", Quantity = 8, Color = "pink" };
            List<Mochi> mochi = new() { };
            mochi.Add(ichigo);
            bool end = false;
            for (int i = 1; end == true; i++)
            {
                Console.WriteLine("write flavor, filling, fruit, quantity, color. one at a time");
                string flavor = Console.ReadLine();
                if (flavor == "end")
                {
                    end = true;
                    break;
                }
                string filling = Console.ReadLine();
                string fruit = Console.ReadLine();
                int quantity = int.Parse(Console.ReadLine());
                string color = Console.ReadLine();
                mochi.Add(new Mochi { Flavor = flavor, Filling = filling, Fruit = fruit, Quantity = quantity, Color = color });
            }
            void list()
            {
                foreach (var item in mochi)
                {
                    Console.WriteLine($"Flavor: {item.Flavor}, Filling: {item.Filling}, Fruit: {item.Fruit}, Quantity: {item.Quantity}, Color: {item.Color}");
                }
            }
            ;
            list();
        }
    }
}
