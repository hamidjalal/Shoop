using Core.Domain;
using Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]/[Action]")]
public class CategoreControlle : ControllerBase
{
    private readonly ICategore _ICategore;
    public CategoreControlle(ICategore ICategore)
    {
        _ICategore = ICategore;
    }
    [HttpPost]
    public IActionResult AddCategore(MCategore Categore)
    {
        var Add = _ICategore.AddCategore(Categore);
        return Ok(Add);
    }
    [HttpPost]
    public string DeleteCategore(int id)
    {
        var Delete = _ICategore.DeleteCategore(id);
        if (Delete)
        {
            return "عملیات با موفقیت انجام شد";
        }
        else
        {
            return "این ایدی وجود ندارد";
        }
    }
    [HttpPost]
    public IActionResult UpdateCategore(MCategore Categore)
    {
        var Add = _ICategore.UpdateCategore(Categore);
        return Ok(Add);
    }
}
