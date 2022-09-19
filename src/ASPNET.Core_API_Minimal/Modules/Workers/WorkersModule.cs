using ASPNET.Core_API_Minimal.Modules.Workers.Models;
using ASPNET.Core_API_Minimal.Modules.Workers.Services;

namespace ASPNET.Core_API_Minimal.Modules.Workers
{
    public class WorkersModule : IModule
    {
        public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/Workers", (IWorkerService workerService) => {
                var workers =  workerService.GetWorkers();
                return Results.Ok(workers);

            }) 
                .Produces<IEnumerable<Worker>>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithTags("Workers");

            endpoints.MapGet("/Workers/{id}", (int id, IWorkerService workerService) =>
            {
                return workerService.GetWorker(id)
                  is Worker worker
                    ? Results.Ok(worker)
                    : Results.NotFound();
            })
                .Produces<Worker>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithTags("Workers");

            return endpoints;
        }
    }
}
