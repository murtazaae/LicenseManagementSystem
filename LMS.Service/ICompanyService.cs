using LMS.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Service
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetCompanies();
        Company GetCompany(long id);
        void InsertCompany(Company company);
        void UpdateCompany(Company company);
        void DeleteCompany(long id);
    }
}
