using AutoMapper;
using ResumeManagerAPI.Core.Dtos;
using ResumeManagerAPI.Core.Entities;

namespace ResumeManagerAPI.Mappings
{
    public class CandidateMappinProfile : Profile
    {
        public CandidateMappinProfile()
        {
            CreateMap<CreateCandidateDto, Candidate>();
            CreateMap<Candidate, GetCandidateDto>()
                .ForMember(dest => dest.JobTitle, opt => opt.MapFrom(src => src.Job.Title));
        }
    }
}
