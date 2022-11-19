using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace MWO.Lab4.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet("version")]
        public IActionResult Index()
        {
            var version = Assembly.GetEntryAssembly()?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            return Ok(version);
        }
    }
}
