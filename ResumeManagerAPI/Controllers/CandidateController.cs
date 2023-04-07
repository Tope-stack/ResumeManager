using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResumeManagerAPI.Core.Dtos;
using ResumeManagerAPI.Core.Entities;
using ResumeManagerAPI.UnitOfWork.Interfaces;

namespace ResumeManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : BaseApiController
    {
        public CandidateController(IServiceManager manager, IMapper mapper) : base(manager, mapper)
        {
            
        }

        [HttpPost] 
        public async Task<IActionResult> Create([FromForm] CreateCandidateDto candidate, IFormFile file)
        {
            var fiveMegaByte = 5 * 1024 * 1024;
            var pdfMimeType = "application/pdf";

            if (file.Length > fiveMegaByte || file.ContentType != pdfMimeType)
            {
                return BadRequest("File is not valid");
            }

            var resumeUrl = Guid.NewGuid().ToString() + ".pdf";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "documents", "pdfs", resumeUrl);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var candidateData = _mapper.Map<Candidate>(candidate);
            candidateData.ResumeUrl = resumeUrl;
            await _service.Candidate.CreateCandidate(candidateData, file);
            await _service.SaveAsync();

            var candidateReturn = _mapper.Map<CandidateDto>(candidateData);
            return Ok(candidateReturn);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var candidates = await _service.Candidate.GetCandidate(trackChanges: false);
            var candidateDto = _mapper.Map<IEnumerable<CandidateDto>>(candidates);
            return Ok(candidateDto);
        }
    }
}
