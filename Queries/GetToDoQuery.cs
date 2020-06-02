using CQRSApi.Responses;
using MediatR;
using System.Collections.Generic;

namespace CQRSApi.Queries
{
    public class GetToDoQuery : IRequest<ToDoResponse>
    {
        public int Id { get; }
        public GetToDoQuery(int id)
        {
            Id = id;
        }
    }
}