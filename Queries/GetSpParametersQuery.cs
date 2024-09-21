using Microsoft.AspNetCore.Mvc;

namespace RTProSLDevTools.Queries;

public class GetSpParametersQuery
{
    [FromQuery]
    public string SpName { get; set; }
}
