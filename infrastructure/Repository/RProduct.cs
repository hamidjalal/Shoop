using System;
using core.Repository;
using Core.Domain;
using infrastructure.Data.Context;

namespace infrastructure.Repository
{
    public class RProduct : IProduct
    {
        private readonly Context _Context;
        public RProduct(Context Context)
        {
            _Context = Context;
        }

        public bool AddCategory(MCategore category)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public List<MCategore> ShowActiveStatus()
        {
            throw new NotImplementedException();
        }

        public List<MCategore> ShowChildCategory(int id)
        {
            throw new NotImplementedException();
        }

        public List<MCategore> ShowDeActiveStatus()
        {
            throw new NotImplementedException();
        }

        public MCategore ShowParentCategory(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory(MCategore category)
        {
            throw new NotImplementedException();
        }
    }
}