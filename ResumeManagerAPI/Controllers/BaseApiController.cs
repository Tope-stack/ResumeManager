using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResumeManagerAPI.UnitOfWork.Interfaces;

namespace ResumeManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        protected readonly IServiceManager _service;
        protected readonly IMapper _mapper;

        public BaseApiController(IServiceManager service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
    }
}
