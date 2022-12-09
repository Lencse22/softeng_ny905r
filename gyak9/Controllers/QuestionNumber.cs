using gyak1011.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gyak1011.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class QuestionNumber : ControllerBase
    {
        [HttpGet]
        [Route("questions/count")]
        public int M4()
        {
            HajosContext context = new HajosContext();
            int kérdésekSzáma = context.Questions.Count();

            return kérdésekSzáma;
        }
    }
}
