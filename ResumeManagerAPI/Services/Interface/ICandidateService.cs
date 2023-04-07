using ResumeManagerAPI.Core.Dtos;
using ResumeManagerAPI.Core.Entities;

namespace ResumeManagerAPI.Services.Interface
{
    public interface ICandidateService
    {
        Task CreateCandidate(Candidate candidate);
        Task GetCandidate(long candidateId, bool trackChanges);
        //Task DownloadPdfFile(string url);

    }
}
