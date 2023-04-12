using AutoMapper;
using ResumeManagerAPI.Core.Dtos;
using ResumeManagerAPI.Core.Entities;

namespace ResumeManagerAPI.Mappings
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            // Candidate Mappings
            CreateMap<CreateCandidateDto, Candidate>();
            CreateMap<Candidate, GetCandidateDto>()
                .ForMember(dest => dest.JobTitle, opt => opt.MapFrom(src => src.Job.Title));


            // Company Mappings
            CreateMap<Company, CompanyDto>();
            CreateMap<CreateCompanyDto, Company>();
            CreateMap<UpdateCompanyDto, Company>().ReverseMap();
            CreateMap<Company, GetCompanyDto>();

            // Job Mapping
            CreateMap<Job, JobDto>().ReverseMap();
            CreateMap<CreateJobDto, Job>();
            CreateMap<Job, GetJobDto>()
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.Name));
            CreateMap<UpdateJobDto, Job>().ReverseMap();
        }
    }
}
