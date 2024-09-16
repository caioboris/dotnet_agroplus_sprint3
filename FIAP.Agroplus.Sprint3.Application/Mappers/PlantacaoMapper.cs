using FIAP.Agroplus.Sprint3.Application.Models;
using FIAP.Agroplus.Sprint3.Domain.Entities;

namespace FIAP.Agroplus.Sprint3.Application.Mappers;

public static class PlantacaoMapper
{
    public static PlantacaoModel ToModel(this PlantacaoEntity entity)
    {
        return new PlantacaoModel
        {
            Id = entity.Id,
            CnpjProdutor = entity.CnpjProdutor,
            NomeProdutor = entity.NomeProdutor,
            Regiao = entity.Regiao.ToModel(),
            RegiaoId = entity.RegiaoId, 
            TamanhoEmHectares = entity.TamanhoEmHectares
        };
    }

    public static PlantacaoEntity ToEntity(this PlantacaoModel model) 
    {
        return new PlantacaoEntity
        {
            Id = Guid.NewGuid(),
            CnpjProdutor = model.CnpjProdutor,
            TamanhoEmHectares = model.TamanhoEmHectares,
            RegiaoId = model.RegiaoId,
            NomeProdutor = model.NomeProdutor,
            Regiao = model.Regiao.ToEntity(),
            DataCriacao = DateTimeOffset.Now
        };
    }

}
