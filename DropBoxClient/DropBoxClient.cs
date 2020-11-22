using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace dBoxClient
{
    class DropBoxClient
    {
        HttpClient _httpClient;
        public DropBoxClient()
        {
            _httpClient = new HttpClient();
        }

        //public async Task<string> Get();
        public async Task<string> Get(string uri = "https://www.dropbox.com/oauth2/authorize")
        {
            var response = await _httpClient.GetAsync(uri);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
