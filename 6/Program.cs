namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Participant amanda = new Participant();
            amanda.Name = "Amanda";
            amanda.Score = 210;
            Participant cleo = new Participant();
            cleo.Name = "Cleo";
            cleo.Score = 220;
            Participant kevin = new Participant();
            kevin.Name = "Kevin";
            kevin.Score = 260;
            Participant qi = new Participant();
            qi.Name = "Qi";
            qi.Score = 310;
            Participant luchino = new Participant();
            luchino.Name = "Luchino";
            luchino.Score = 240;
            Participant lily = new Participant();
            lily.Name = "Lily";
            lily.Score = 200;
            Participant ada = new Participant();
            ada.Name = "Ada";
            ada.Score = 150;
            Participant emil = new Participant();
            emil.Name = "Emil";
            emil.Score = 250;
            List<Participant> championship = new List<Participant>();
            championship.Add(amanda);
            championship.Add(cleo);
            championship.Add(kevin);
            championship.Add(qi);
            championship.Add(luchino);
            championship.Add(lily);
            championship.Add(ada);
            championship.Add(emil);
            championship.Sort((x, y) => y.CompareTo(x));
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"Winner: {championship[i].Name}");
                }
                Console.WriteLine($"{i+1}: {championship[i].Name}, Score: {championship[i].Score}");
            }
            for (int i = 0; i < championship.Count; i++)
            {
                if (i == championship.Count-1)
                {
                    Console.WriteLine($"last: {championship[i].Name}");
                }
            }
        }
    }
}
