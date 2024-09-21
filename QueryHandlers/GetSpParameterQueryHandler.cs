using Microsoft.EntityFrameworkCore;
using RTProSLDevTools.Data;
using RTProSLDevTools.Dtos;
using RTProSLDevTools.Models;
using RTProSLDevTools.Queries;
using RTProSLDevTools.QueryHandlers.Contracts;
using RTProSLDevTools.QueryHandlers.Response.Contracts;

namespace RTProSLDevTools.QueryHandlers;

public class GetSpParameterQueryHandler(AppDbContext appDbContext)
    : AsyncQueryHandler<GetSpParametersQuery, IEnumerable<GetSpParametersDto>>
{
    public async override Task<IApiResponse<IEnumerable<GetSpParametersDto>>> HandleAsync(GetSpParametersQuery query)
    {
        var spParameters = from e in appDbContext.Set<SpParameter>()
                           where AppDbContext.OBJECT_ID(query.SpName) == e.ObjectId
                           select new GetSpParametersDto
                           {
                               ObjectId = e.ObjectId,
                               Name = e.Name,
                               MaxLength = e.MaxLength,
                               SystemTypeId = e.SystemTypeId,
                               Precision = AppDbContext.TYPE_NAME(e.SystemTypeId) == "uniqueidentifier"
                                   ? e.Precision
                                   : AppDbContext.OdbcPrec(e.SystemTypeId, e.MaxLength, e.Precision!.Value)
                           };

        return Respond(await spParameters.ToListAsync());
    }
}
