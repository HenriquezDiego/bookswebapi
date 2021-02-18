﻿using System;
using AutoMapper;
using BooksWebApi.Models.Entities;

namespace BooksWebApi.WiewModels.Config
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DateTime, string>()
                .ConvertUsing(x => x.ToString(@"dd/MM/yyyy"));


            CreateMap<string, string>().ConstructUsing(x => x.Trim());

            CreateMap<Cliente, ClienteViewModel>();
        }
    }
}
