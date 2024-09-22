using Microsoft.EntityFrameworkCore;
using RTProSLDevTools.Data;
using RTProSLDevTools.Dtos;
using RTProSLDevTools.Models;
using RTProSLDevTools.Queries;
using RTProSLDevTools.QueryHandlers.Contracts;
using RTProSLDevTools.QueryHandlers.Response.Contracts;

namespace RTProSLDevTools.QueryHandlers;

public class GetSpParameterQueryHandler(AppDbContext appDbContext)
    : AsyncQueryHandler<SpParametersQuery, IEnumerable<SpParametersDto>>
{
    public async override Task<IApiResponse<IEnumerable<SpParametersDto>>> HandleAsync(SpParametersQuery query)
    {
        var spParameters = from e in appDbContext.Set<SpParameter>()
                           where AppDbContext.OBJECT_ID(query.SpName) == e.ObjectId
                           select new SpParametersDto
                           {
                               ObjectId = e.ObjectId,
                               Name = e.Name,
                               MaxLength = e.MaxLength,
                               SystemTypeId = e.SystemTypeId,
                               ParameterId = e.ParameterId,
                               UserTypeId = e.UserTypeId,
                               IsOutput = e.IsOutput,
                               IsCursorRef = e.IsCursorRef,
                               HasDefaultValue = e.HasDefaultValue,
                               IsXmlDocument = e.IsXmlDocument,
                               DefaultValue = e.DefaultValue,
                               XmlCollectionId = e.XmlCollectionId,
                               IsReadonly = e.IsReadonly,
                               IsNullable = e.IsNullable,
                               EncryptionType = e.EncryptionType,
                               EncryptionTypeDesc = e.EncryptionTypeDesc,
                               EncryptionAlgorithmName = e.EncryptionAlgorithmName,
                               ColumnEncryptionKeyId = e.ColumnEncryptionKeyId,
                               ColumnEncryptionKeyDatabaseName = e.ColumnEncryptionKeyDatabaseName,
                               Scale = AppDbContext.OdbcScale(e.SystemTypeId, e.Scale),
                               TypeName = AppDbContext.TYPE_NAME(e.SystemTypeId),
                               //Collation = 
                               Precision = AppDbContext.TYPE_NAME(e.SystemTypeId) == "uniqueidentifier"
                                   ? e.Precision
                                   : AppDbContext.OdbcPrec(e.SystemTypeId, e.MaxLength, e.Precision!.Value)
                           };

        return Respond(await spParameters.ToListAsync());
    }
}
