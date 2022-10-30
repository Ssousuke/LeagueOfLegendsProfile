using Api.Models;
using Newtonsoft.Json;

namespace Api.API
{
    public class League_V4 : Api
    {
        public League_V4(string region) : base(region)
        {
        }

        public List<PositionDTO> GetPositions(string summonerId)
        {
            string path = $"league/v4/entries/by-summoner/{summonerId}";
            var response = GET(GetUri(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<List<PositionDTO>>(content);
            return null;
        }
    }
}
