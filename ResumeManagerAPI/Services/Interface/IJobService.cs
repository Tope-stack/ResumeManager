using ResumeManagerAPI.Core.Entities;

namespace ResumeManagerAPI.Services.Interface
{
    public interface IJobService
    {
        Task CreateJob(Job job);
        Task<IEnumerable<Job>> GetAllJobs(bool trackChanges);
        Task DeleteJob(Job job);
    }
}
