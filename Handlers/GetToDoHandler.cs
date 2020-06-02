using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CQRSApi.Queries;
using CQRSApi.Repository;
using CQRSApi.Responses;
using MediatR;

namespace CQRSApi.Handlers
{
    public class GetToDoHandler : IRequestHandler<GetToDoQuery, ToDoResponse>
    {
        private IToDosRepository _toDoRepository;
        public GetToDoHandler(IToDosRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public async Task<ToDoResponse> Handle(GetToDoQuery request, CancellationToken cancellationToken)
        {
            var todo =  await _toDoRepository.GetToDoAsync(request.Id);
            return todo;
        }
         
    }
}