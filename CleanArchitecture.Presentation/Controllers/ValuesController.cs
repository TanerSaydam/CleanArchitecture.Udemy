using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public sealed class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Deneme api işlemi başarılı!");
        }
    }
}
