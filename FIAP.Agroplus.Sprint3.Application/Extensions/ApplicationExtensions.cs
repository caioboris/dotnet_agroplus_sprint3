using FIAP.Agroplus.Sprint3.Application.Services;
using FIAP.Agroplus.Sprint3.Application.Services.Interfaces;
using FIAP.Agroplus.Sprint3.Application.Servicesç;
using Microsoft.Extensions.DependencyInjection;

namespace FIAP.Agroplus.Sprint3.Application.Extensions;

public static class ApplicationExtensions
{

    public static void AddServices(this IServiceCollection services)
    {
        services.AddTransient<IRegiaoService, RegiaoService>();
        services.AddTransient<IPlantacaoService, PlantacaoService>();
    }

}
