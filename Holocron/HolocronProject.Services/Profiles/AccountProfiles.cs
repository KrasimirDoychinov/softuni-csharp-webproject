using AutoMapper;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Services.Profiles
{
    public class AccountProfiles : Profile
    {
        public AccountProfiles()
        {
            CreateMap<Account, ForeignAccountDto>();
        }
    }
}
