namespace RTProSLDevTools.QueryHandlers.Response.Contracts
{
    public interface IApiResponseException
    {
        Exception? Exception { get; }
    }
}