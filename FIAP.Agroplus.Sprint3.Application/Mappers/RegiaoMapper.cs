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
            Nome = entity.Nome,
            PlantioMaisFrequente = entity.PlantioMaisFrequente,
            PrecipitacaoMedia = entity.PrecipitacaoMedia,
            RegiaoBR = entity.RegiaoBR.ToString(),
            TemperaturaMedia = entity.TemperaturaMedia,
        };
    }

    public static RegiaoEntity ToEntity(this RegiaoModel model) 
    {
        return new RegiaoEntity
        {
            Id = Guid.NewGuid(),
            Nome = model.Nome,
            PlantioMaisFrequente = model.PlantioMaisFrequente,
            PrecipitacaoMedia = model.PrecipitacaoMedia,
            RegiaoBR = (RegiaoBR)Enum.Parse(typeof(RegiaoBR), model.RegiaoBR),
            TemperaturaMedia = model.TemperaturaMedia,
            DataCriacao = DateTimeOffset.Now
        };
    }

}
