using ClientRegistrey.BusinessObjects.Backend.Interfaces.CreateClient;
using ClientRegistrey.BusinessObjects.Backend.UseCase;
namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddUseCaseServiceAddPresentersServices(
        this IServiceCollection services)
    {
        services.AddSingleton<ICreateClientInputPort, CreateClientInteractor>();
        return services;
    }
}
