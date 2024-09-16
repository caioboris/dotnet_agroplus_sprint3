using FIAP.Agroplus.Sprint3.Application.Mappers;
using FIAP.Agroplus.Sprint3.Application.Models;
using FIAP.Agroplus.Sprint3.Application.Services.Interfaces;
using FIAP.Agroplus.Sprint3.Domain.Contracts.Repositories;
using FIAP.Agroplus.Sprint3.Domain.Enums;

namespace FIAP.Agroplus.Sprint3.Application.Servicesç
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository)
        {
            _regiaoRepository = regiaoRepository;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var regiao = await _regiaoRepository.GetByIdAsync(id);

            if (regiao == null)
                return false;

            return await _regiaoRepository.DeleteAsync(regiao);
        }

        public async Task<IEnumerable<RegiaoModel>> GetAllAsync()
        {
            var result = await _regiaoRepository.GetAllAsync();
            return result.Select(x => x.ToModel());
        }

        public async Task<RegiaoModel?> GetAsync(Guid id)
        {
            var regiao = await _regiaoRepository.GetByIdAsync(id);
            return regiao?.ToModel();
        }

        public async Task<bool> InsertAsync(RegiaoModel model)
        {
            return await _regiaoRepository.InsertAsync(model.ToEntity());
        }

        public async Task<bool> UpdateAsync(Guid id, RegiaoModel model)
        {
            var regiao = await _regiaoRepository.GetByIdAsync(id);

            if (regiao == null)
                return false;

            regiao.TemperaturaMedia = model.TemperaturaMedia;
            regiao.PlantioMaisFrequente = model.PlantioMaisFrequente;
            regiao.DataAtualizacao = DateTimeOffset.Now;
            regiao.Nome= model.Nome;
            regiao.RegiaoBR = (RegiaoBR) Enum.Parse(typeof(RegiaoBR), model.RegiaoBR);
            regiao.PrecipitacaoMedia = model.PrecipitacaoMedia;

            return await _regiaoRepository.UpdateAsync(regiao);
        }
    }
}
