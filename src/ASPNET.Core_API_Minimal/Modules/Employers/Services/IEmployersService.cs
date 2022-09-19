using ASPNET.Core_API_Minimal.Modules.Employers.Models;

namespace ASPNET.Core_API_Minimal.Modules.Employers.Services
{
    public interface IEmployersService
    {
        public IEnumerable<Employer> GetEmployers();
        public Employer? GetEmployer(int id);
    }
}
