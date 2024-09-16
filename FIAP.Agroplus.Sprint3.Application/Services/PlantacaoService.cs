using FIAP.Agroplus.Sprint3.Application.Mappers;
using FIAP.Agroplus.Sprint3.Application.Models;
using FIAP.Agroplus.Sprint3.Application.Services;
using FIAP.Agroplus.Sprint3.Domain.Contracts.Repositories;

namespace FIAP.Agroplus.Sprint3.Application.Servicesç
{
    public class PlantacaoService : IPlantacaoService
    {
        private readonly IPlantacaoRepository _plantacaoRepository;

        public PlantacaoService(IPlantacaoRepository plantacaoRepository)
        {
            _plantacaoRepository = plantacaoRepository;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _plantacaoRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<PlantacaoModel>> GetAllAsync()
        {
            var result = await _plantacaoRepository.GetAllAsync();
            return result.Select(x => x.ToModel());
        }

        public async Task<PlantacaoModel?> GetAsync(Guid id)
        {
            var plantacao = await _plantacaoRepository.GetByIdAsync(id);
            return plantacao?.ToModel();
        }

        public async Task<bool> InsertAsync(PlantacaoModel model)
        {
            return await _plantacaoRepository.InsertAsync(model.ToEntity());
        }

        public async Task<bool> UpdateAsync(Guid id, PlantacaoModel model)
        {
            var plantacao = await _plantacaoRepository.GetByIdAsync(id);

            if(plantacao == null)
                return false;

            plantacao.CnpjProdutor = model.CnpjProdutor;
            plantacao.NomeProdutor = model.NomeProdutor;
            plantacao.DataAtualizacao = DateTimeOffset.Now;
            plantacao.Regiao = model.Regiao.ToEntity();
            plantacao.RegiaoId = model.RegiaoId;

            return await _plantacaoRepository.UpdateAsync(plantacao);
        }
    }
}
