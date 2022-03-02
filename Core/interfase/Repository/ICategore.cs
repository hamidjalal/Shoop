using System;
using Core.Domain;
namespace Core.Repository
{
    public interface ICategore
    {
        bool AddCategore(MCategore Categore);
        bool UpdateCategore(MCategore Categore);
        bool DeleteCategore(int id);
        List<MCategore> ShowChildCategore(int id);
        MCategore ShowParentCategore(int id);
        List<MCategore> ShowActiveStatus();
        List<MCategore> ShowDeActiveStatus();
    }
}