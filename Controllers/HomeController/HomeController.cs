using Microsoft.AspNetCore.Mvc;
namespace helloWorld
{
    public class HomeController : Controller // Home is the name of the directory where all of these actions/views should reference
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }


        [HttpGet]
        [Route("projects")]
        public ViewResult Projects()
        {
            return View("Projects");
        }
        
        [HttpGet]
        [Route("contact")]
        public ViewResult Contact()
        {
            return View("Contact");
        }
    }
}