using ASPNET.Core_API_Minimal.Modules.Workers.Models;

namespace ASPNET.Core_API_Minimal.Modules.Workers.Services
{
    public class WorkerService : IWorkerService
    {
        private readonly IEnumerable<Worker> fakeData;

        public WorkerService()
        {
            fakeData = new List<Worker> {
                 new Worker{ Id = 1, CompanyId = 1, Name = "Carlos", SurName = "Ruiz", StartDate = new DateTime(2019,10,22)},
                 new Worker{ Id = 2, CompanyId = 1, Name = "Marta", SurName = "Lago", StartDate = new DateTime(2020,05,11)},
                 new Worker{ Id = 3, CompanyId = 2, Name = "´Gemma", SurName = "Armans", StartDate = new DateTime(2015,01,13)}
             };
        }


        public IEnumerable<Worker> GetWorkers()
        {
            return fakeData;
        }
        public Worker? GetWorker(int id)
        {
            return fakeData.FirstOrDefault(x => x.Id == id);
        }
    }

}
