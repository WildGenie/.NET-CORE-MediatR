using CQRSApi.Commands;
using CQRSApi.Repository;
using CQRSApi.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSApi.Handlers
{
    public class CreateToDoHandler : IRequestHandler<CreateToDoCommand, ToDoResponse>
    {
        private IToDosRepository _toDoRepository;
        public CreateToDoHandler(IToDosRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public async Task<ToDoResponse> Handle(CreateToDoCommand request, CancellationToken cancellationToken)
        {
            var todo = await _toDoRepository.CreateToDoAsync(request.userId, request.title);
            return todo;
        } 
    }
}
