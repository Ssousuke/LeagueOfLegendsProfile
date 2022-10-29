﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api.API
{
    public class Api
    {
        private string Key { get; set; }
        private string Region { get; set; }


        public Api(string region)
        {
            Region = region;
            Key = GetKey();
        }

        protected HttpResponseMessage GET(string Uri)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(Uri);
                result.Wait();
                return result.Result;
            }
        }

        public string GetKey()
        {
            return "RGAPI-61761fff-69ee-4917-b8db-03a8df88959a";
        }

        protected string GetUri(string path)
        {
            return $"https://{Region}.api.riotgames.com/lol/{path}?api_key={Key}";
        }
    }
}
