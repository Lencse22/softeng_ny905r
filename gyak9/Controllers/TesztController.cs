using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gyak1011.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]

    public class TesztController : ControllerBase
    {
        [HttpGet]
        [Route("corvinus/szerverido")]
        public IActionResult ido()
        {
            string pontosIdő = DateTime.Now.ToShortTimeString();

            return Ok(pontosIdő);
        }

        [HttpGet]
        [Route("corvinus/nagybetus/{szoveg}")]
        public IActionResult M2(string szoveg)
        {
            return Ok(szoveg.ToUpper());
            return BadRequest("Nem jó a bemenő adat");

        }
    }
}