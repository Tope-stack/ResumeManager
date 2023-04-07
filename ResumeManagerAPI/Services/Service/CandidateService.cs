using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ResumeManagerAPI.Core.Dtos;
using ResumeManagerAPI.Core.Entities;
using ResumeManagerAPI.Data;
using ResumeManagerAPI.Services.Interface;
using ResumeManagerAPI.UnitOfWork.Services;

namespace ResumeManagerAPI.Services.Service
{
    public class CandidateService : ServiceBase<Candidate>, ICandidateService
    {
        public CandidateService(AppDbContext dbContext) : base(dbContext)
        {

        }
        public async Task CreateCandidate(Candidate candidate) =>
            await CreateAsync(candidate);


        //public Task DownloadPdfFile(string url)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task GetCandidate(long candidateId, bool trackChanges) =>
            await FindByConditionAsync(c => c.ID.Equals(candidateId), trackChanges).Result.SingleOrDefaultAsync();
        
    }
}
