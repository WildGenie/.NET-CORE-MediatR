using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CQRSApi.Helper
{
    public interface IClientHelper
    {
        HttpRequestMessage GenerateMessage(int? id);
        Task<HttpResponseMessage> CallUrlAsync(int? id);
    }
}
