using System;
using System.Collections.Generic;
using System.Text;
using LMS.Data;
using LMS.Repo;

namespace LMS.Service
{
    public class CompanyService : ICompanyService
    {

        private IRepository<Company> companyRepository;
        //private IRepository<NamedCaller> namedcallerRepository;

        public CompanyService(IRepository<Company> companyRepository)
        {
            this.companyRepository = companyRepository;
//            this.namedcallerRepository = namedcallerRepository;
        }

        public void DeleteCompany(long id)
        {
            Company company = companyRepository.Get(id);
            company.IsActive = false;
            company.IsDeleted = true;
            companyRepository.SaveChanges();
        }

        public IEnumerable<Company> GetCompanies()
        {
            return companyRepository.GetAll();
        }

        public Company GetCompany(long id)
        {
            return companyRepository.Get(id);
        }

        public void InsertCompany(Company company)
        {
            companyRepository.Insert(company);
        }

        public void UpdateCompany(Company company)
        {
            companyRepository.Update(company);
        }
    }
}
