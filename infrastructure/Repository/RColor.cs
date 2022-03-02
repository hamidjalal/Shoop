using System.Drawing;
using System;
using AutoMapper;
using Core.Domain;
using Core.Repository;
using infrastructure.Data.Context;
using infrastructure.Data.Entites;

namespace infrastructure.Repository
{
    public class RColor : IColor
    {
        private readonly Context _Context;
        private readonly IMapper _IMap;
        public RColor(Context Context, IMapper IMap)
        {
            _Context = Context;
            _IMap = IMap;
        }
        public bool AddColor(MColor Color)
        {
            var Add = _IMap.Map<Tbl_Color>(Color);
            _Context.Colors.Add(Add);
            _Context.SaveChanges();
            return true;
        }

        public bool DeleteColor(int IdColor)
        {
            throw new NotImplementedException();
        }

        public List<MColor> ShowColor(int IdColor)
        {
            throw new NotImplementedException();
        }

        public bool UpdateColor(MColor Color)
        {
            throw new NotImplementedException();
        }
    }
}