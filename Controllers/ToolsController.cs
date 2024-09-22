using Microsoft.AspNetCore.Mvc;
using RTProSLDevTools.Controllers.Base;
using RTProSLDevTools.Dtos;
using RTProSLDevTools.Models;
using RTProSLDevTools.Queries;
using RTProSLDevTools.QueryHandlers.Response.Contracts;

namespace RTProSLDevTools.Controllers;

[ApiController]
[Route("[controller]")]
public class ToolsController : MyApiController
{
    [HttpGet]
    public async Task<IApiResponse> GetSpParameters(SpParametersQuery query)
        => await HandleAsync<SpParametersQuery, IEnumerable<SpParametersDto>>(query);

    [HttpPost]
    public async Task<IApiResponse> GetQueryResultSetColumns(QueryResultSetColumnsQuery query)
        => await HandleAsync<QueryResultSetColumnsQuery, IEnumerable<QueryResultSetColumnDto>>(query);
}
