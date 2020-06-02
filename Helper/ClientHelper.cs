using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CQRSApi.Helper
{
    public class ClientHelper : IClientHelper
    {
        private readonly IHttpClientFactory _clientFactory;
        public ClientHelper(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public HttpRequestMessage GenerateMessage(int? id)
        {
            if (id.HasValue)
                return new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholder.typicode.com/todos/" + id);

            return new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholder.typicode.com/todos");
        }
        public async Task<HttpResponseMessage> CallUrlAsync(int? id)
        {
            var request = GenerateMessage(id.HasValue ? id : null);
            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);
            return response;

        }
    }
}
