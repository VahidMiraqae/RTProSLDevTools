using Microsoft.AspNetCore.Mvc;
using RTProSLDevTools.Queries;
using RTProSLDevTools.Results;

namespace RTProSLDevTools.Controllers;

[ApiController]
[Route("[controller]")]
public class ToolsController(IQueryHandler queryHandler) :
    ControllerBase
{
    [HttpGet]
    public Task<IActionResult> GetSpParameters(GetSpParametersQuery<GetSpParametersDto> query)
    {
        file
        return queryHandler.Handle(query);
    }
}


public class MyController : Controller
{

}