using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ValuesController : ControllerBase
  {
    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return "Mayank Aggarwal";
    }
  }
}