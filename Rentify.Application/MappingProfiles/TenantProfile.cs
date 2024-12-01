using AutoMapper;
using Rentify.Application.DTOs.Tenant;
using Rentify.Domain.Entities;

namespace Rentify.Application.MappingProfiles
{
    public class TenantProfile: Profile
    {
        public TenantProfile()
        {
            CreateMap<Tenant, TenantDto>().ReverseMap();
            CreateMap<CreateTenantDto, Tenant>();
            CreateMap<EditTenantDto, Tenant>();
        }
    }
}
