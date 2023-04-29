using Microsoft.AspNetCore.Mvc;

namespace Project.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AliController : ControllerBase
{
    private readonly ILogger<AliController> _logger;

    public AliController(ILogger<AliController> logger)
    {
        _logger = logger;
    }
}
