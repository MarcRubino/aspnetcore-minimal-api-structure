using ASPNET.Core_API_Minimal.Modules.Workers.Models;

namespace ASPNET.Core_API_Minimal.Modules.Workers.Services
{
    public interface IWorkerService
    {
        public IEnumerable<Worker> GetWorkers();
        public Worker? GetWorker(int id);
    }
}
