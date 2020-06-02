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
    public class GetToDosHandler : IRequestHandler<GetToDosQuery, List<ToDoResponse>>
    {
        private IToDosRepository _toDoRepository;
        public GetToDosHandler(IToDosRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public async Task<List<ToDoResponse>> Handle(GetToDosQuery request, CancellationToken cancellationToken)
        {
            var toDos =  await _toDoRepository.GetToDosAsync();
            return toDos;
        }
    }
}