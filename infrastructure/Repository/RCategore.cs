using System;
using System.Collections.Generic;
using AutoMapper;
using Core.Domain;
using Core.Repository;
using infrastructure.Data.Context;
using infrastructure.Data.Entites;

namespace infrastructure.Repository
{
    public class RCategore : ICategore
    {
        private readonly Context _Context;
        private readonly IMapper _IMap;
        public RCategore(Context Context, IMapper IMap)
        {
            _Context = Context;
            _IMap = IMap;
        }
        public bool AddCategore(MCategore Categore)
        {
            var Add = _IMap.Map<Categore>(Categore);
            _Context.categores.Add(Add);
            _Context.SaveChanges();
            return true;
        }

        public bool DeleteCategore(int id)
        {
            var Delete = _Context.categores.SingleOrDefault(u => u.Id == id);
            if (Delete != null)
            {
                _Context.categores.Remove(Delete);
                _Context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<MCategore> ShowActiveStatus()
        {
            throw new NotImplementedException();
        }

        public List<MCategore> ShowChildCategore(int id)
        {
            throw new NotImplementedException();
        }

        public List<MCategore> ShowDeActiveStatus()
        {
            throw new NotImplementedException();
        }

        public MCategore ShowParentCategore(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategore(MCategore Categore)
        {
            throw new NotImplementedException();
        }
    }
}