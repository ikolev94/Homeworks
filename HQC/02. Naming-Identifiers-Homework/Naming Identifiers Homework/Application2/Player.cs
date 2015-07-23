namespace Minesweeper
{
    public class Player
    {
        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public int Points { get; set; }

        public string Name { get; set; }
    }
}