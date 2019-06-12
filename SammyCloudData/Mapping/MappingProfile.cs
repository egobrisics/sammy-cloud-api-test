using AutoMapper;
using SammyCloudData.DTOs;
using SammyCloudData.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SammyCloudData.Mapping
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<Account, AccountDto>();
            CreateMap<Patient, PatientDto>();
        }
    }
}
