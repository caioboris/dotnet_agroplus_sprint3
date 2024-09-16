using FIAP.Agroplus.Sprint3.Application.Models;
using FIAP.Agroplus.Sprint3.Domain.Entities;
using FIAP.Agroplus.Sprint3.Domain.Enums;

namespace FIAP.Agroplus.Sprint3.Application.Mappers;

public static class RegiaoMapper
{
    public static RegiaoModel ToModel(this RegiaoEntity entity)
    {
        return new RegiaoModel
        {
            Id = entity.Id,
            Nome = entity.Nome,
            PlantioMaisFrequente = entity.PlantioMaisFrequente,
            PrecipitacaoMedia = entity.PrecipitacaoMedia,
            RegiaoBR = entity.RegiaoBR.ToString(),
            TemperaturaMedia = entity.TemperaturaMedia,
        };
    }

    public static RegiaoEntity ToEntity(this RegiaoModel model) 
    {
        var regiaobr = Enum.TryParse(typeof(RegiaoBR), model.RegiaoBR, out object? result);
        if (!regiaobr)
        {
            throw new ArgumentException("Região BR inválida, escolha entre as opções:  CENTRO_OESTE,\r\n    SUL,\r\n    SUDESTE,\r\n    NORTE,\r\n    NORDESTE ");
        }

        return new RegiaoEntity
        {
            Id = Guid.NewGuid(),
            Nome = model.Nome,
            PlantioMaisFrequente = model.PlantioMaisFrequente,
            PrecipitacaoMedia = model.PrecipitacaoMedia,
            RegiaoBR = (RegiaoBR) result,
            TemperaturaMedia = model.TemperaturaMedia,
            DataCriacao = DateTimeOffset.Now
        };
    }

}
