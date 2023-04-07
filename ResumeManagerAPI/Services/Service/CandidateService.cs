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
        public async Task CreateCandidate(Candidate candidate, IFormFile pdfFile) =>
            await CreateAsync(candidate);


        public Task DownloadPdfFile(string url)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Candidate>> GetCandidate(bool trackChanges) =>
            await FindAllAsync(trackChanges).Result.OrderBy(c => c.CreatedAt).ToListAsync();
        
    }
}
