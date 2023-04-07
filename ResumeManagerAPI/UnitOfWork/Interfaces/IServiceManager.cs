using ResumeManagerAPI.Services.Interface;

namespace ResumeManagerAPI.UnitOfWork.Interfaces
{
    public interface IServiceManager
    {
        ICandidateService Candidate { get; }
        ICompanyService Company { get; }
        IJobService Job { get; }
        Task SaveAsync();
    }
}
