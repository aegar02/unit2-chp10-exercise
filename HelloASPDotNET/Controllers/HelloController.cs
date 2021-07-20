using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string openingFormTag = "<form method='post' action='/helloworld/'>";
            string closingFormTag = "</form>";
            string nameInputTag = "<input type='text' name='name'/>";
            string submitInputTag = "<input type='submit' value='Greet Me!' />";

            string html = openingFormTag + nameInputTag + submitInputTag + closingFormTag;
                
            return Content(html, "text/html");
        }

        //GET: /hello/welcome
        //[HttpGet]
        //[Route("/helloworld/welcome/{name?}")]

        [HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }

        public static IActionResult Createmessage()
        {
            string openingFormTag = "<form method='post' action='/helloworld/'>";
            string closingFormTag = "</form>";
            string nameInputTag = "<input type='text' name='name'/>";

            string openingSelectTag = "<select name='languages' id='language-select'>";
            string openingOptionTag = "<option value='' value = '--Please choose a language--'</option>" +
                        "<option value = 'en' value = 'Hello'>English</option>" +
                        "<option value = 'fr' value = 'Bonjour'>French</option>" +
                        "<option value = 'de' value = 'Hallo'>German</option>" +
                        "<option value = 'it' value = 'Ciao'>Italian</option>" +
                        "<option value = 'es' value = 'Hola'>Spanish</option>";

            string closingOptionTag = "</option>";
            string closingSelectTag = "</select>";

            string submitInputTag = "<input type='submit' value='Greet Me!' />";

            string html = openingFormTag + nameInputTag + openingSelectTag + openingOptionTag + closingOptionTag + closingSelectTag + submitInputTag + closingFormTag;

            //return Content(html, "text/html");

        }

        
        
    }
}
