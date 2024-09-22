using Microsoft.EntityFrameworkCore;
using RTProSLDevTools.Data;
using RTProSLDevTools.Models;
using RTProSLDevTools.Queries;
using RTProSLDevTools.QueryHandlers.Contracts;
using RTProSLDevTools.QueryHandlers.Response.Contracts;

namespace RTProSLDevTools.QueryHandlers
{
    public class QueryResultSetColumnQueryHandler(AppDbContext appDbContext)
        : AsyncQueryHandler<QueryResultSetColumnsQuery, IEnumerable<QueryResultSetColumnDto>>
    {
        public async override Task<IApiResponse<IEnumerable<QueryResultSetColumnDto>>> HandleAsync(QueryResultSetColumnsQuery query)
        {
            var dbConnection = appDbContext.Database.GetDbConnection();
            using var command = dbConnection.CreateCommand();
            command.CommandText = query.Sql;
            var dbReader = await command.ExecuteReaderAsync();
            var list = new List<QueryResultSetColumnDto>();
            for (int i = 0; i < dbReader.FieldCount; i++)
            {
                list.Add(new QueryResultSetColumnDto
                {
                    Name = dbReader.GetName(i),
                    Type = dbReader.GetFieldType(i).Name,
                    Index = i,
                    IsNullable = dbReader.IsDBNull(i)
                });
            }
            return Respond(list);
        }
    }
}
