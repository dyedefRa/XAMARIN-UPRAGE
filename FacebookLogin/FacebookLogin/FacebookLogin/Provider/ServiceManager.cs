using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogin.Provider
{
    public class ServiceManager<T> where T : class
    {
        private async Task<HttpClient> GetClient()
        {
            HttpClient client = new HttpClient();
            return client;
        }

        public async Task<T> GetFacebookProfile(string accessToken)
        {
            var httpClient = await GetClient();
            var requestUrl = "https://graph.facebook.com/v2.7/me?fields=name,picture,work,website,religion,location,locale,link,cover,age_range,birthday,devices,email,first_name,last_name,gender,hometown,is_verified,languages&access_token="
              + accessToken;

            var userJson = await httpClient.GetStringAsync(requestUrl);
            var profile = JsonConvert.DeserializeObject<T>(userJson);
            return profile;
        }

        public async Task<T> Get(string url)
        {
            var httpClient = await GetClient();
            var response =await httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<T>(response);
        }

    }
}
