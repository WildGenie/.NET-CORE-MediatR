using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSApi.Commands;
using CQRSApi.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ToDosController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetToDos()
        {
            var query = new GetToDosQuery();
            var result = await _mediator.Send(query);
            return result!=null ? (IActionResult) Ok(result) : NotFound();
        }

        [HttpGet("{id:int}")] 
        public async Task<IActionResult> GetToDo(int id)
        {
            var query = new GetToDoQuery(id);
            var result = await _mediator.Send(query);
            return result != null ? (IActionResult)Ok(result) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CreateToDo([FromBody] CreateToDoCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction("GetToDo",routeValues: new { id= result.id }, value: result);
        } 
    }


}
