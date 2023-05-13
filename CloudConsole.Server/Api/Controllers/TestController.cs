namespace CloudConsole.Server.Api.Controllers;

using CloudConsole.Server.Api.Models;

public class TestController : BaseApiController
{
    [HttpGet]
    public IActionResult Time()
    {
        return Ok(new TestTimeResponse { DateTime = DateTime.Now });
    }

    [HttpGet]
    public IActionResult Error()
    {
        throw new InvalidOperationException("API error.");
    }
}
