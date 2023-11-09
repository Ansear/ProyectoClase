using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using WebApi.Dtos;

namespace WebApi.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<Country, CountryNameDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<PersonType, PersonTypeDto>().ReverseMap();
            CreateMap<State, StateDto>().ReverseMap();
        }
    }
}