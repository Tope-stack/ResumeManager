using ResumeManagerAPI.Core.Dtos;
using ResumeManagerAPI.Core.Entities;

namespace ResumeManagerAPI.Services.Interface
{
    public interface ICandidateService
    {
        Task CreateCandidate(Candidate candidate, IFormFile pdfFile);
        Task<IEnumerable<Candidate>> GetCandidate(bool trackChanges);
        Task DownloadPdfFile(string url);

    }
}
