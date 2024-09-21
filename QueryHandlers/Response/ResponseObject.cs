using System.Text.Json.Serialization;

namespace RTProSLDevTools.QueryHandlers.Response;

public class ResponseObject
{
    public ResponseObject()
    {

    }

    public ResponseObject(int status, IEnumerable<string> messages)
    {
        Status = status;
        Messages = messages;
    }

    public ResponseObject(object? model, object? metadata = null)
    {
        Model = model;
        Metadata = metadata;
    }

    public int? Status { get; set; }

    public IEnumerable<string> Messages { get; set; } = [];

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public object? Model { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public object? Metadata { get; set; }
}