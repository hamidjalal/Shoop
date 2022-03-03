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
    public List<MCategore> ShowActiveStatus()
    {
        return _ICategore.ShowActiveStatus();
    }
    [HttpPost]
    public List<MCategore> ShowChildCategory(int id)
    {
        return _ICategore.ShowChildCategore(id);
    }
    [HttpPost]
    public List<MCategore> ShowDeActiveStatus()
    {
        return _ICategore.ShowDeActiveStatus();
    }
    [HttpPost]
    public MCategore ShowParentCategory(int id)
    {
        return _ICategore.ShowParentCategore(id);
    }
    [HttpPost]
    public string UpdateCategory(MCategore category)
    {
        var result = _ICategore.UpdateCategore(category);
        if (result)
        {
            return "عملیات با موفقیت انجام شد";
        }
        else
        {
            return "این آیدی وجود ندارد";
        }
    }
}
