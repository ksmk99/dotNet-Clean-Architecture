﻿using Application.Commands;
using Application.Responses;
using AutoMapper;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public class HeroMappingProfile : Profile
    {
        public HeroMappingProfile()
        {
            CreateMap<Hero, HeroResponse>().ReverseMap();
            CreateMap<Hero, CreateHeroCommand>().ReverseMap();
        }
    }
}
