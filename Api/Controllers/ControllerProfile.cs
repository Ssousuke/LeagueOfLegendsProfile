using Api.API;
using Api.Models;
using Api.Utils;
using Api.ViewModel;

namespace Api.Controllers
{
    public class ControllerProfile
    {
        public object GetContext(SummonerDTO summoner)
        {
            var position = GetPosition(summoner);
            return new ViewModelProfile(summoner.name, summoner.profileIconId, summoner.summonerLevel, position.Tier, position.Rank, position.Wins, position.Losses);
        }
        private PositionDTO GetPosition(SummonerDTO summoner)
        {
            League_V4 league = new League_V4(Constants.Region);
            var position = league.GetPositions(summoner.id).Where(x => x.QueueType.Equals("RANKED_SOLO_5X5")).FirstOrDefault();
            if (position != null) return position; return new PositionDTO();
        }
    }
}
