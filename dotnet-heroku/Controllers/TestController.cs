using Microsoft.AspNetCore.Mvc;

namespace dotnet_heroku.Controllers
{
    [Route("/")]
    public class TestController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Running";
        }

    }
}
