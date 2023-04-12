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
    public class JobController : BaseApiController
    {
        public JobController(IServiceManager manager, IMapper mapper) : base(manager, mapper)
        {

        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateJobDto job)
        {
            var jobData = _mapper.Map<Job>(job);
            await _service.Job.CreateJob(jobData);
            await _service.SaveAsync();

            var jobReturn = _mapper.Map<JobDto>(jobData);

            return Ok(jobReturn);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var jobs = await _service.Job.GetAllJobs(trackChanges: false);
            var jobDto = _mapper.Map<IEnumerable<JobDto>>(jobs);
            return Ok(jobDto);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(JobDto job)
        {
            var jobData = _mapper.Map<Job>(job);
            await _service.Job.DeleteJob(jobData);
            await _service.SaveAsync();

            return Ok("Job is successfully deleted");
        }
    }
}
