namespace RTProSLDevTools.Models;

public class QueryResultSetColumnDto
{
    public string? Type { get; set; }
    public string? Name { get; set; }
    public int Index { get; set; }
    public short MaxLength { get; set; }
    public int? Precision { get; set; }
    public bool? IsNullable { get; set; }
}
