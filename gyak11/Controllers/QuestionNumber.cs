using hajos.Modul;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hajos.Controllers
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
