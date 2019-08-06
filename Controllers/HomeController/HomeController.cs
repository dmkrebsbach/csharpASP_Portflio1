using Microsoft.AspNetCore.Mvc;
namespace helloWorld
{
    public class homeController : Controller 
    {
        //Requests
        //localhost:5000/
        [HttpGet("")]
        public string Index()
        {
            return "This is my Index!!!";
        }

        //localhost:5000/hello
        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects";
        }

        //localhost:5000/contacts
        [HttpGet("contacts")]
        public string Contacts()
        {
            return "This is My Contact Info!";
        }


    }
}