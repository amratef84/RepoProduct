
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Features.Sizes.Commands.CreateSize;
using Products.Application.Features.Sizes.Queries.GetSizesList;
using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Projects.Api.Controllers
{

    [Route("api/size/[controller]")]
    [ApiController]
    public class SizeController : ControllerBase
    {


        private readonly IMediator _mediator;

        public SizeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllSizes")]
        public async Task<ActionResult<List<GetSizesListViewModel>>> GetAllSizes()
        {
            var dtos = await _mediator.Send(new GetSizesListQuery());
            return Ok(dtos);
        }

        //[HttpGet("{id}", Name = "GetSizeById")]
        //public async Task<ActionResult<GetBrancheDetailViewModel>> GetPostById(Guid id)
        //{
        //    var getEventDetailQuery = new GetBrancheDetailQuery() { BrancheId = id };
        //    return Ok(await _mediator.Send(getEventDetailQuery));
        //}

        [HttpPost(Name = "AddSize")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateSizeCommand createSizeCommand)
        {
            Guid id = await _mediator.Send(createSizeCommand);
            return Ok(id);
        }




    }
}