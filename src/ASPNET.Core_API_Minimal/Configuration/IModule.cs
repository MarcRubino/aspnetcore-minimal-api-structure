namespace ASPNET.Core_API_Minimal
{
    public interface IModule
    {
        IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints);
    }
}
