using Api.API;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class ControllerMain
    {
        public bool GetSummoner(string region, string summonerName)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4(region);
            var summoner = summoner_V4.GetSummonerByName(summonerName);
            return summoner != null;
        }
    }
}
