using Api.API;
using Api.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace Api.Controllers
{
    public class ControllerMain
    {
        public bool GetSummoner(String summonerName)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4(Constants.Region);
            var summoner = summoner_V4.GetSummonerByName(summonerName);
            Constants.Summoner = summoner;
            return summoner != null;
        }
    }
}
