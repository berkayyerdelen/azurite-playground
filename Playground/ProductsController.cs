using Microsoft.AspNetCore.Mvc;

namespace Playground;
[ApiController]
[Route("v1/api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Products()
    {
        return Ok("product");
    }
  
}