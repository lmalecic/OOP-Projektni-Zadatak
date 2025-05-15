namespace DAL
{
    public class PlayerStats
    {
        public Player Player { get; internal set; }
        public int GoalsScored { get; internal set; }
        public int YellowCards { get; internal set; }
        public int Appearances { get; internal set; }
    }
}