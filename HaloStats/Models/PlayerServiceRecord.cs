namespace HaloStats.Models
{
    public record PlayerServiceRecord
    {
        public struct data
        {
            public struct summary
            {
                public int kills { get; set; }
                public int deaths { get; set; }
                public int assists { get; set; }
                public int betrayals { get; set; }
                public int suicides { get; set; }
                public int MyProperty { get; set; }
            }
            
            public struct vehicles 
            {
                public int destroys { get; set; }
                public int hijacks { get; set; }
            }

            public int medals { get; set; }

            public struct damage 
            {
                public int taken { get; set; }
                public int dealt { get; set; }
                public int average { get; set; }
            }

            public struct shots 
            {
                public int fired { get; set; }
                public int landed { get; set; }
                public int missed { get; set; }
                public int accuracy { get; set; }
            }

            public struct breakdowns 
            {
                public int kills { get; set; }
                public int assists { get; set; }
                public int matches { get; set; }
            }

            public int kda { get; set; }
            public int kdr { get; set; }
            public int total_score { get; set; }
            public int matches_played { get; set; }
            
            public struct time_played
            {
                public int seconds { get; set; }
                public string human { get; set; }
            }

            public int win_rate { get; set; }

            public struct additional 
            {
                public string gamertag { get; set; }
            }
        }
    }
}
