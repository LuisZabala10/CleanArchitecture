namespace ContactsCL.Application.Mappings.Profiles
{
    using AutoMapper;
    using ContactsCL.Application.Dtos;
    using ContactsCL.Domain.Entities;
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<Contact, ContactDto>()
                .ForMember(dest => dest.Contact, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.TelephoneNumbers, opt => opt.MapFrom(src => src.TelephoneNumbers));
        }
    }
}
