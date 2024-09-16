using FIAP.Agroplus.Sprint3.Domain.Contracts.Repositories;
using FIAP.Agroplus.Sprint3.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FIAP.Agroplus.Sprint3.Infrastructure.Extensions;

public static class InfrastructureExtensions
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<IPlantacaoRepository, PlantacaoRepository>();
        services.AddTransient<IRegiaoRepository, RegiaoRepository>();
    }

}
