using AutoMapper;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.ConsoleApp
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Account, AccountViewModel>();
            this.CreateMap<Account, ForeignAccountDto>();
            this.CreateMap<Character, CharacterViewModel>();
            this.CreateMap<Race, RaceDto>();
            this.CreateMap<Server, ServerDto>();
            
        }
    }
}
