using Microsoft.AspNetCore.Mvc;
using RTProSLDevTools.Controllers.Base;
using RTProSLDevTools.Dtos;
using RTProSLDevTools.Queries;
using RTProSLDevTools.QueryHandlers.Response.Contracts;

namespace RTProSLDevTools.Controllers;

[ApiController]
[Route("[controller]")]
public class ToolsController : MyApiController
{
    [HttpGet]
    public async Task<IApiResponse> GetSpParameters(GetSpParametersQuery query)
        => await HandleAsync<GetSpParametersQuery, IEnumerable<GetSpParametersDto>>(query);
}
