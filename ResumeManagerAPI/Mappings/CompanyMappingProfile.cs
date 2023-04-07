using AutoMapper;
using ResumeManagerAPI.Core.Dtos;
using ResumeManagerAPI.Core.Entities;

namespace ResumeManagerAPI.Mappings
{
    public class CompanyMappingProfile : Profile
    {
        public CompanyMappingProfile()
        {
            CreateMap<Company, CompanyDto>();

            CreateMap<CreateCompanyDto, Company>();

            CreateMap<UpdateCompanyDto, Company>().ReverseMap();

            CreateMap<CreateCompanyDto, Company>();

            CreateMap<Company, GetCompanyDto>();
        }
    }
}
