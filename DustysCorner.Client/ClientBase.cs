using DustysCorner.Client.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace DustysCorner.Client
{
    public class ClientBase
    {
        public readonly ApiSettings ApiSettings;

        public ClientBase(ApiSettings apiSettings)
        {
            ApiSettings = apiSettings;
        }

        public async Task<T> GetRequest<T>(string method)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiSettings.Address);
                var response = await client.GetAsync(method);
                var contents = await response.Content.ReadAsStringAsync();
                return await ReadResponse<T>(response);
            }
        }

        private async Task<T> ReadResponse<T>(HttpResponseMessage response)
        {
            var contents = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<T>(contents);
            }
            else
            {
                var errorResponse = new ErrorModel
                {
                    StatusCode = (int)response.StatusCode,
                    Message = response.ReasonPhrase
                };
                throw new ApiException(errorResponse);
            }
        }
    }
}
