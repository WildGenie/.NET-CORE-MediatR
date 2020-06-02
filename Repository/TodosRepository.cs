using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CQRSApi.Helper;
using CQRSApi.Responses;

namespace CQRSApi.Repository
{
    public class ToDosRepository : IToDosRepository
    {
        private readonly IClientHelper _clientHelper;
        public ToDosRepository(IClientHelper clientHelper)
        { 
            _clientHelper = clientHelper;
        }

        public async Task<ToDoResponse> CreateToDoAsync(string userId, string title)
        {
            //API create desteklemediği için 2. todo nesnesini döndürelim.
            var response = await _clientHelper.CallUrlAsync(2);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsAsync<ToDoResponse>();
            else
                return null;
        }

        public async Task<ToDoResponse> GetToDoAsync(int id)
        {
            var response = await _clientHelper.CallUrlAsync(id);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsAsync<ToDoResponse>();
            else
                return null;
        }

        public async Task<List<ToDoResponse>> GetToDosAsync()
        {
            var response = await _clientHelper.CallUrlAsync(null);
            if (response.IsSuccessStatusCode) 
                return await response.Content.ReadAsAsync<List<ToDoResponse>>();  
            else 
                return null; 
        }  
    }
}
