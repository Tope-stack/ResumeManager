using AutoMapper;
using ResumeManagerAPI.Data;
using ResumeManagerAPI.Services.Interface;
using ResumeManagerAPI.Services.Service;
using ResumeManagerAPI.UnitOfWork.Interfaces;

namespace ResumeManagerAPI.UnitOfWork.Services
{
    public class ServiceManager : IServiceManager
    {
        private AppDbContext _context;
        private ICompanyService _companyService;
        private IJobService _jobService;
        private ICandidateService _candidateService;
       

        public ServiceManager(AppDbContext context)
        {
            _context = context;
        }

        public ICandidateService Candidate
        {
            get
            {
                if (_candidateService is null)
                    _candidateService = new CandidateService(_context);
                return _candidateService;
            }
        }
        

        public ICompanyService Company 
        {
            get
            {
                
                
                    if (_companyService is null)
                        _companyService = new CompanyService(_context);
                    return _companyService;
                
            }
        }

        public IJobService Job
        {
            get
            {
                if (_jobService is null)
                    _jobService = new JobService(_context);
                return _jobService;
            }
        }

        

        public Task SaveAsync() => _context.SaveChangesAsync();
        
    }
}
