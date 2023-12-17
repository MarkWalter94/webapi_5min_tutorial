using Microsoft.AspNetCore.Mvc;
using Tutorial.DTOs;

namespace Tutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<TestResponse> TestGet()
        {
            return new TestResponse()
            {
                Success = true,
                Token = null
            };
        }

        [HttpGet("{nomeUtente}")]
        public ActionResult<TestResponse> TestGet(string nomeUtente)
        {
            return new TestResponse()
            {
                Success = true,
                Token = nomeUtente
            };
        }

        [HttpPost]
        public ActionResult<TestResponse> TestPost(TestRequest request)
        {
            if(request.Username.Equals("marco", StringComparison.InvariantCultureIgnoreCase))
            {
                return new TestResponse()
                {
                    Success = true,
                    Token = "Ciao Marco!",
                };
            }
            return BadRequest("Non sei marco :(");
        }
    }
}
