using ASPNET.Core_API_Minimal.Modules.Employers.Models;

namespace ASPNET.Core_API_Minimal.Modules.Employers.Services
{
    public class EmployersService : IEmployersService
    {
        private readonly IEnumerable<Employer> fakeData;
        public EmployersService()
        {
            fakeData = new List<Employer> {
                    new Employer{ Id = 1, Name = "Construcciones Paco"},
                    new Employer{ Id = 2, Name = "Limpiezas Secas"}
             };
        }

        public Employer? GetEmployer(int id)
        {
            return fakeData.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Employer> GetEmployers()
        {
            return fakeData;
        }
    }
}
