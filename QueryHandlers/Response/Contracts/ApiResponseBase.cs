using System.Net;
using System.Net.Mime;

namespace RTProSLDevTools.QueryHandlers.Response.Contracts;

public abstract class ApiResponseBase
    : IApiResponse
{
    public string? ContentType { get; set; }
    public int? StatusCode { get; set; }
    public List<ApiMessage> Messages { get; } = [];
    public Exception? Exception { get; }

    protected ApiResponseBase()
    {

    }

    protected ApiResponseBase(Exception ex)
    {
        Exception = ex;
    }

    public async Task ExecuteAsync(HttpContext httpContext)
    {
        if (Exception is not null)
        {
            var status = (int)HttpStatusCode.InternalServerError;
            var messages = new List<string>() { Exception.Message };
            await FinishReponse(new(status, messages));
            return;
        }

        await FinishReponse(MakeObject());

        async Task FinishReponse(ResponseObject obj)
        {
            obj.Status ??= StatusCode ?? (int)HttpStatusCode.OK;
            obj.Messages = [.. obj.Messages, .. PrepareMessages()];
            ContentType ??= MediaTypeNames.Application.Json;
            await httpContext.Response.WriteAsJsonAsync(obj);
        }
    }

    protected virtual ResponseObject MakeObject()
    {
        return new();
    }

    private IEnumerable<string> PrepareMessages()
    {
        return Messages.Select(a => string.Format(a.Template, a.Values));
    }
}
