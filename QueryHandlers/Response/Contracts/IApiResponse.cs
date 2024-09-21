namespace RTProSLDevTools.QueryHandlers.Response.Contracts
{
    public interface IApiResponse
        : IResult
        , IStatusCodeHttpResult
        , IApiResponseMessage
        , IApiResponseException
    {
    }

    public interface IApiResponse<TValue>
        : IApiResponse
        , IValueHttpResult<TValue>
    {
        object? Metadata { get; }
    }
}