using Api.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ViewModel
{
    public class ViewModelProfile
    {
        public ViewModelProfile(string name, int profileIconId, long summonerLevel, string tier, string rank, int wins, int losses)
        {
            Tier = tier;
            Rank = rank;
            Wins = wins;
            Losses = losses;
        }

        public string SummonerName { get; set; }
        public string Icon { get; private set; }
        public long Level { get; private set; }
        public string Tier { get; private set; }
        public string Rank { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }

    }
}
