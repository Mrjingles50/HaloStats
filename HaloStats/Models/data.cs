
namespace HaloStats.Models
{
    public record data
    {
        public Summary Summary { get; set; }
        public Damage Damage { get; set; }
        public Shots Shots { get; set; }
        public Breakdowns Breakdowns { get; set; }
        public double kda { get; set; }
        public double kdr { get; set; }
        public int total_score { get; set; }
        public int matches_played { get; set; }
        public Time_played Time_played { get; set; }
        public double win_rate { get; set; }
        public Additional Additional { get; set; }
    }
}
