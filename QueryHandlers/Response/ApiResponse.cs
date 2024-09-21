using RTProSLDevTools.QueryHandlers.Response.Contracts;

namespace RTProSLDevTools.QueryHandlers.Response;

public class ApiResponse<T>
    : ApiResponseBase
    , IApiResponse<T>
{
    public T? Value { get; }
    public object? Metadata { get; set; }

    public ApiResponse(T? value)
    {
        Value = value;
    }

    public ApiResponse(Exception ex) : base(ex) { }

    protected override ResponseObject MakeObject()
    {
        return new()
        {
            Model = Value,
            Metadata = Metadata,
        };
    }
}
