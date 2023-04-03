
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Features.Branches.Commands.CreateBranche;
using Products.Application.Features.Branches.Queries.GetBrancheDetail;
using Products.Application.Features.Branches.Queries.GetBranchesList;
using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Projects.Api.Controllers
{
    [Route("api/branches/[controller]")]
    [ApiController]
    public class BrancheController : ControllerBase
    {


        private readonly IMediator _mediator;

        public BrancheController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllBranches")]
        public async Task<ActionResult<List<GetBranchesListViewModel>>> GetAllBranches()
        {
            var dtos = await _mediator.Send(new GetBranchesListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetBrancheById")]
        public async Task<ActionResult<GetBrancheDetailViewModel>> GetBrancheById(Guid id)
        {
            var getEventDetailQuery = new GetBrancheDetailQuery() { BrancheId = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpPost(Name = "AddBranche")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateBrancheCommand createBrancheCommand)
        {
            Guid id = await _mediator.Send(createBrancheCommand);
            return Ok(id);
        }




    }
}