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
            var Show = _Context.categores.Where(c => c.Status == "1").ToList();
            if (Show != null)
            {
                List<MCategore> categores = new List<MCategore>();
                foreach (var item in Show)
                {
                    MCategore c = new MCategore()
                    {
                        Name = item.Name,
                        ParentId = item.ParentId
                    };
                    categores.Add(c);
                }
                return categores;
            }
            else
            {
                return null;
            }
        }

        public List<MCategore> ShowChildCategore(int id)
        {
            var Show = _Context.categores.Where(c => c.ParentId == id && c.Status == "1").ToList();
            if (Show != null)
            {
                List<MCategore> categores = new List<MCategore>();
                foreach (var item in Show)
                {
                    MCategore c = new MCategore()
                    {
                        Name = item.Name,
                        ParentId = item.ParentId
                    };
                    categores.Add(c);
                }
                return categores;
            }
            else
            {
                return null;
            }
        }

        public List<MCategore> ShowDeActiveStatus()
        {
            var Show = _Context.categores.Where(c => c.Status == "0").ToList();
            if (Show != null)
            {
                List<MCategore> categores = new List<MCategore>();
                foreach (var item in Show)
                {
                    MCategore c = new MCategore()
                    {
                        Name = item.Name,
                        ParentId = item.ParentId
                    };
                    categores.Add(c);
                }
                return categores;
            }
            else
            {
                return null;
            }
        }

        public MCategore ShowParentCategore(int id)
        {
            var Show = _Context.categores.SingleOrDefault(c => c.Id == id).ParentId;
            var Parent = _Context.categores.SingleOrDefault(p => p.Id == Show);
            MCategore c = new MCategore();
            c.Name = Parent.Name;
            c.ParentId = Parent.ParentId;
            return c;
        }

        public bool UpdateCategore(MCategore Categore)
        {
            var Update = _Context.categores.SingleOrDefault(c => c.Id == Categore.Id);
            if (Update != null)
            {
                Update.Name = Categore.Name;
                Update.ParentId = Categore.ParentId;
                Update.Status = Categore.Status;
                _Context.Update(Update);
                _Context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}