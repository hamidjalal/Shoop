using Core.Domain;
using Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]/[Action]")]
public class ProductControlle : ControllerBase
{
    private readonly ICategore _ICategore;
    public ProductControlle(ICategore ICategore)
    {
        _ICategore = ICategore;
    }
}