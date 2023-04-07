using AutoMapper;
using ResumeManagerAPI.Core.Dtos;
using ResumeManagerAPI.Core.Entities;

namespace ResumeManagerAPI.Mappings
{
    public class JobMappingProfile : Profile
    {
        public JobMappingProfile()
        {
            CreateMap<Job, JobDto>();

            //CreateMap<CreateJobDto, Job>()
            //    .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.Name));
            CreateMap<CreateJobDto, Job>();
            CreateMap<Job, GetJobDto>()
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.Name));


            CreateMap<UpdateJobDto, Job>().ReverseMap();
        }
        
    }
}
