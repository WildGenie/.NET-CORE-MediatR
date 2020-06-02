using CQRSApi.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSApi.Commands
{
    public class CreateToDoCommand : IRequest<ToDoResponse>
    {
        public string userId { get; set; }
        public string title { get; set; }
    }
}
