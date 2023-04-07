
using ResumeManagerAPI.Core.Dtos;
using ResumeManagerAPI.Core.Entities;

namespace ResumeManagerAPI.Services.Interface
{
    public interface ICompanyService
    {
        Task AddNewCompany(Company company);
        Task<IEnumerable<Company>> GetAllCompanies(bool trackChanges);
        //Task<Company> GetCompanyById(long id);
    }
}
