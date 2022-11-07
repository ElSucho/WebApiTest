using Microsoft.AspNetCore.Mvc;

namespace WebApiTest.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hello");
        }
    }
}
