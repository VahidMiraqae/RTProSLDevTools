using RTProSLDevTools.QueryHandlers.Response.Contracts;

namespace RTProSLDevTools.QueryHandlers.Contracts
{
    public interface IQueryHandler<T, TDto>
    {
        IApiResponse<TDto> Handle(T query);
    }
}