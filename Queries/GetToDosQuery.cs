using CQRSApi.Responses;
using MediatR;
using System.Collections.Generic;

namespace CQRSApi.Queries
{
    public class GetToDosQuery : IRequest<List<ToDoResponse>>
    {
        public GetToDosQuery()
        {
        }
    }
}