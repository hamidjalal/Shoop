using System;
using Core.Domain;
namespace Core.Repository
{
    public interface IColor
    {
        bool AddColor(MColor Color);
        bool UpdateColor(MColor Color);
        bool DeleteColor(int IdColor);
        List<MColor> ShowColor(int IdColor);
    }
}