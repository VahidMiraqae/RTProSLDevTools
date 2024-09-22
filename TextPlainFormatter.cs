using Microsoft.AspNetCore.Mvc.Formatters;
using System.Text;

namespace RTProSLDevTools
{
    public class TextPlainFormatter
        : TextInputFormatter
    {
        public override Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context, Encoding encoding)
        {
            SystemTextJsonInputFormatter
            throw new NotImplementedException();
        }
    }
}
