using RTProSLDevTools.QueryHandlers.Response.Contracts;

namespace RTProSLDevTools.QueryHandlers.Contracts
{
    public abstract class QueryHandler<T, TDto>
        : IQueryHandler<T, TDto>
    {
        public abstract IApiResponse<TDto> Handle(T query);
    }
}