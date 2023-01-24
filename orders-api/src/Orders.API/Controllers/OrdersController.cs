using Microsoft.AspNetCore.Mvc;
namespace Orders.API.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class OrdersController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }
}
