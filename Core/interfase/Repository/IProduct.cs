using System;
using System.Collections.Generic;
using Core.Domain;
namespace core.Repository
{
    public interface IProduct
    {
        bool AddCategory(MCategore category); 
        bool UpdateCategory(MCategore category);
        bool DeleteCategory(int id);
        List<MCategore> ShowChildCategory(int id);
        MCategore ShowParentCategory(int id);
        List<MCategore> ShowActiveStatus();
        List<MCategore> ShowDeActiveStatus();
    }
}