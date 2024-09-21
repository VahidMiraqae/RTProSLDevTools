namespace RTProSLDevTools.QueryHandlers.Response.Contracts
{
    public interface IApiResponseMessage
    {
        public List<ApiMessage> Messages { get; }
    }
}