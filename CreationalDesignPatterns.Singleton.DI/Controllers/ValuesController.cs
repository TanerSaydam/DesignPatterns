using CreationalDesignPatterns.Singleton.DI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CreationalDesignPatterns.Singleton.DI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    private readonly IUserService _userService;

    public ValuesController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        _userService.Register();
        return NoContent();
    }
}
