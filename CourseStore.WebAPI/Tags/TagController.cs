using CourseStore.Model.Tags.Commands;
using CourseStore.Model.Tags.Queries;
using CourseStore.WebAPI.Framework;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseStore.WebAPI.Tags;
public class TagController : BaseController
{
    public TagController(IMediator mediator) : base(mediator)
    {
    }
    [HttpPost("CreateTag")]
    public async Task<IActionResult> CreateTag(CreateTag Tag)
    {
        var response = await mediator.Send(Tag);
        return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
    }


    [HttpPut("UpdateTag")]
    public async Task<IActionResult> UpdateTag(UpdateTag Tag)
    {
        var response = await mediator.Send(Tag);
        return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
    }

    [HttpGet("FilterByName")]
    public async Task<IActionResult> SearchTag([FromQuery]FilterByName Tag)
    {
        var response = await mediator.Send(Tag);
        return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
    }

}

