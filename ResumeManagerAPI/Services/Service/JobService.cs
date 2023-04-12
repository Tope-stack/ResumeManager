using Microsoft.EntityFrameworkCore;
using ResumeManagerAPI.Core.Entities;
using ResumeManagerAPI.Data;
using ResumeManagerAPI.Services.Interface;
using ResumeManagerAPI.UnitOfWork.Services;

namespace ResumeManagerAPI.Services.Service
{
    public class JobService : ServiceBase<Job>,IJobService
    {
        public JobService(AppDbContext dbContext) : base(dbContext)
        {

        }
        public async Task CreateJob(Job job) => await CreateAsync(job);

        public async Task DeleteJob(Job job) => await RemoveAsync(job);
        

        public async Task<IEnumerable<Job>> GetAllJobs(bool trackChanges) =>
            await FindAllAsync(trackChanges).Result.OrderBy(c => c.CreatedAt).ToListAsync();


       
    }
}
