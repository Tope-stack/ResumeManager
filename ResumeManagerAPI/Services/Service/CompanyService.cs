using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ResumeManagerAPI.Core.Dtos;
using ResumeManagerAPI.Core.Entities;
using ResumeManagerAPI.Data;
using ResumeManagerAPI.Services.Interface;
using ResumeManagerAPI.UnitOfWork.Services;
using System.ComponentModel.Design;

namespace ResumeManagerAPI.Services.Service
{
    public class CompanyService : ServiceBase<Company>, ICompanyService
    {
        
        public CompanyService(AppDbContext dbContext) : base(dbContext)
        {

        }

        public async Task AddNewCompany(Company company) => await CreateAsync(company);


        public async Task<IEnumerable<Company>> GetAllCompanies(bool trackChanges) =>
            await FindAllAsync(trackChanges).Result.OrderBy(c => c.Name).ToListAsync();

        

    }
}
