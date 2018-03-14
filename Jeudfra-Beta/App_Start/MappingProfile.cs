using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using System.ComponentModel.DataAnnotations;
using Jeudfra_Beta.Models;
using Jeudfra_Beta.Dtos;

namespace Jeudfra_Beta.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           
            Mapper.CreateMap<Client, CustomerDto>();
           // Mapper.CreateMap<CustomerDto, Client>();
            Mapper.CreateMap<Policy, PolicyDto>();

            Mapper.CreateMap<Payment, NewPaymentDto>();

            Mapper.CreateMap<Address, AddressDto>();

            Mapper.CreateMap<Spouse, SpouseDto>();

            Mapper.CreateMap<UnderWriter, UnderWriterDto>();

            // Dto to Domain
            Mapper.CreateMap<CustomerDto, Client>()
                            .ForMember(c => c.Id, opt => opt.Ignore());
            
            Mapper.CreateMap<PolicyDto, Policy>()
                            .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<NewPaymentDto, Payment>()
                            .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}