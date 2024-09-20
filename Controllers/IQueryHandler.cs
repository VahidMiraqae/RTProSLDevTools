using Microsoft.AspNetCore.Mvc;

namespace RTProSLDevTools.Controllers
{
    public interface IQueryHandler
    {
        Task<IActionResult> Handle<T>(T query);
    }
}