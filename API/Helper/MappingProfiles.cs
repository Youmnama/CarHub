﻿using API.DTO;
using AutoMapper;
using Core.Entities;
namespace API.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Car, CarDTO>().
                ForMember(d => d.ImagePath, o => o.MapFrom<CarUrlResolver>()).
                ForMember(d => d.Name, o => o.MapFrom(o => o.Brand.Name + " "  + o.Model.Name + " " + o.ModelVariant));
        }

    }
}
