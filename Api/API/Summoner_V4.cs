using Api.Models;
using Newtonsoft.Json;

namespace Api.API
{
    public class Summoner_V4 : Api
    {
        public Summoner_V4(string region) : base(region)
        {
        }

        public SummonerDTO GetSummonerByName(string summonerName)
        {
            string path = $"summoner/v4/summoners/by-name/{summonerName}";
            var response = GET(GetUri(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<SummonerDTO>(content);
            return null;

        }
    }
}
