using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResumeManagerAPI.Core.Dtos;
using ResumeManagerAPI.Core.Entities;
using ResumeManagerAPI.Services.Interface;
using ResumeManagerAPI.UnitOfWork.Interfaces;

namespace ResumeManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : BaseApiController
    {
        public CompanyController(IServiceManager manager, IMapper mapper) : base(manager, mapper)   
        {

        }

        [HttpPost]
        public async Task<IActionResult> CreateCompanyy([FromBody]  CreateCompanyDto company)
        {
            var companyData = _mapper.Map<Company>(company);
            await _service.Company.AddNewCompany(companyData);
            await _service.SaveAsync();

            var companyReturn = _mapper.Map<CompanyDto>(companyData);

            return Ok(companyReturn);

            //return CreatedAtRoute("CompanyById",
            //    new
            //    {
            //        companyId = companyReturn.ID
            //    },
            //    companyReturn);
        }

        [HttpGet]
        public async Task<IActionResult> GetCompany()
        {
            var companies = await _service.Company.GetAllCompanies(trackChanges: false);
            var companyDto = _mapper.Map<IEnumerable<CompanyDto>>(companies);
            return Ok(companyDto);
        }
    }
}
