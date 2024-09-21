using RTProSLDevTools.QueryHandlers.Response.Contracts;

namespace RTProSLDevTools.QueryHandlers.Contracts
{
    public interface IAsyncQueryHandler<T, TDto>
    {
        Task<IApiResponse<TDto>> HandleAsync(T query);
    }
}