using Microsoft.AspNetCore.Mvc;

namespace RTProSLDevTools.Queries;

public class SpParametersQuery
{
    [FromQuery]
    public string SpName { get; set; }
}
