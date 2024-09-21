using RTProSLDevTools.QueryHandlers.Response;
using RTProSLDevTools.QueryHandlers.Response.Contracts;

namespace RTProSLDevTools.QueryHandlers.Contracts
{
    public abstract class AsyncQueryHandler<T, TDto>
        : IAsyncQueryHandler<T, TDto>
    {
        public abstract Task<IApiResponse<TDto>> HandleAsync(T query);

        protected IApiResponse<TDto> Respond(TDto dto)
        {
            return new ApiResponse<TDto>(dto);
        }
    }
}