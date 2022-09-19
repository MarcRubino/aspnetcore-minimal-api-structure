using ASPNET.Core_API_Minimal.Modules.Employers.Models;
using ASPNET.Core_API_Minimal.Modules.Employers.Services;

namespace ASPNET.Core_API_Minimal.Modules.Employers
{
    public class EmployersModule : IModule
    {
        public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/Employers", (IEmployersService employerService)=> {
                var employers = employerService.GetEmployers();
                return Results.Ok(employers);
            
            })
                .Produces<IEnumerable<Employer>>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithTags("Employers");


            endpoints.MapGet("/Employers/{id}", (int id, IEmployersService employerService) =>
            {
                return employerService.GetEmployer(id)
                  is Employer employer
                    ? Results.Ok(employer)
                    : Results.NotFound();
            })
                .Produces<Employer>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithTags("Employers");

            return endpoints;
        }
    }
}
