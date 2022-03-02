using Core.Domain;
using Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]/[Action]")]
public class ColorControlle : ControllerBase
{
    private readonly IColor _IColor;
   public ColorControlle(IColor IColor)
    {
        _IColor = IColor;
    }

    [HttpPost]
    public IActionResult AddColor(MColor Color)
    {
       var b = _IColor.AddColor(Color);
       return Ok(b);
    }
}

