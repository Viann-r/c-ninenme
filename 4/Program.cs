namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contain Lanternist = new();
            Lanternist.Name = "Amanda";
            Lanternist.Hp = 100;
            Lanternist.Lvl = 100;
            Lanternist.ContainAbility = "Living Image";
            Lanternist.KiteZone = "Pallet";
            Assist MimeArtist = new();
            MimeArtist.Name = "Cleo";
            MimeArtist.Hp = 100;
            MimeArtist.Lvl = 3;
            MimeArtist.StunAbility = "UmbrellaStun";
            MimeArtist.SupportAbility = "UmbrellaFly";
            Rescue Cowboy = new();
            Cowboy.Name = "Kevin";
            Cowboy.Hp = 100;
            Cowboy.Lvl = 10;
            Cowboy.RescueAbility = "LassoTechnique";
            Cowboy.Helpafterrescue = "Carry";


            Lanternist.ShowInfo();
            Lanternist.Attack();
            Lanternist.Defend();
            MimeArtist.ShowInfo();
            MimeArtist.Attack();
            MimeArtist.Defend();
            Cowboy.ShowInfo();
            Cowboy.Attack();
            Cowboy.Defend();
        }
    }
}
