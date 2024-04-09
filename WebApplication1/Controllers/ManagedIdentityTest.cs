using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class ManagedIdentityTest : ControllerBase
{
    private readonly IConfiguration _configuration;

    public ManagedIdentityTest(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return Ok(_configuration.GetValue<string>("SubMessage:Message"));
    }
}
