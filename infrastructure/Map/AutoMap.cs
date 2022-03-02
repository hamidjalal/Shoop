using System.Drawing;
using System;
using AutoMapper;
using Core.Domain;
using infrastructure.Data.Entites;
namespace infrastructure.Map;

public class AutoMap:Profile
{
    public AutoMap()
    {
         CreateMap<MCategore,Categore>().ReverseMap();
         CreateMap<MColor,Tbl_Color>().ReverseMap();
    }
}
