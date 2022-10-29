namespace Api.Models
{
    public class PositionDTO
    {
        public string Tier { get; set; }
        public string Rank { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public string QueueType { get; set; }

        //public PositionDTO(string tier, string rank, int wins, int losses, string queueType)
        //{
        //    Tier = tier;
        //    Rank = rank;
        //    Wins = wins;
        //    Losses = losses;
        //    QueueType = queueType;
        //}
    }
}
