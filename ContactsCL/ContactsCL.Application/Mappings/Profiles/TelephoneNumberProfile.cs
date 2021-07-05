using AutoMapper;
using ContactsCL.Application.Dtos;
using ContactsCL.Domain.Entities;

namespace ContactsCL.Application.Mappings.Profiles
{
    public class TelephoneNumberProfile : Profile
    {
        public TelephoneNumberProfile()
        {
            CreateMap<TelephoneNumber, TelephoneNumberDto>();
        }
    }
}
