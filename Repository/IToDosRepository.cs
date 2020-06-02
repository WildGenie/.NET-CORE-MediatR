using CQRSApi.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSApi.Repository
{
    public interface IToDosRepository
    {
        Task<List<ToDoResponse>> GetToDosAsync();
        Task<ToDoResponse> GetToDoAsync(int id);
        Task<ToDoResponse> CreateToDoAsync(string userId, string title);
    }
}
