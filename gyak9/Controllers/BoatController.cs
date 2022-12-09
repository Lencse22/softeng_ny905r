using gyak1011.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gyak1011.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        [HttpGet]
        [Route("questions/all")]
        public IActionResult M1()
        {
            HajosContext context = new HajosContext();
            var kerdesek = from x in context.Questions select x.Question1;

            return new JsonResult(kerdesek);
        }
    }
}
