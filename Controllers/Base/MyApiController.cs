using Microsoft.AspNetCore.Mvc;
using RTProSLDevTools.QueryHandlers.Contracts;
using RTProSLDevTools.QueryHandlers.Response;
using RTProSLDevTools.QueryHandlers.Response.Contracts;

namespace RTProSLDevTools.Controllers.Base;

public class MyApiController : ControllerBase
{
    protected IApiResponse<TDto> Handle<T, TDto>(T query)
    {
        return HandleAsync<T, TDto>(query).Result;
    }

    protected async Task<IApiResponse<TDto>> HandleAsync<T, TDto>(T query)
    {
        var handler = Request.HttpContext.RequestServices.GetRequiredService<AsyncQueryHandler<T, TDto>>();
        try
        {
            return await handler.HandleAsync(query);
        }
        catch (Exception ex)
        {
            return new ApiResponse<TDto>(ex);
        }
        finally
        {

        }
    }
}
