namespace RTProSLDevTools.QueryHandlers.Response.Contracts
{
    public class ApiMessage
    {
        public ApiMessage(string template, params object[] values)
        {
            Template = template;
            Values = values;
        }
        public string Template { get; set; }
        public object[] Values { get; set; }
    }
}