using FIAP.Agroplus.Sprint3.Application.DTOs;
using FIAP.Agroplus.Sprint3.Application.Models;
using FIAP.Agroplus.Sprint3.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace FIAP.Agroplus.Sprint3.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlantacaoController : ControllerBase
{

    private readonly IPlantacaoService _plantacaoService;

    public PlantacaoController(IPlantacaoService plantacaoService)
    {
        _plantacaoService = plantacaoService;
    }

    /// <summary>
    /// Rota utilizada para obter uma plantacão a partir do seu id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    [Produces<PlantacaoModel>]
    public async Task<IActionResult> GetById(Guid id)
    {
        var plantacao = await _plantacaoService.GetAsync(id);
        return plantacao == null ? BadRequest() : Ok(plantacao);
    }

    /// <summary>
    /// Rota utilizada para obter todas as plantações
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Produces<IEnumerable<PlantacaoModel>>]
    public async Task<IActionResult> GetAll()
    {
        var plantacao = await _plantacaoService.GetAllAsync();
        return plantacao == null ? BadRequest() : Ok(plantacao);
    }

    /// <summary>
    /// Rota utilizada para cadastrar uma plantacão
    /// </summary>
    /// <param name="body">Nova plantacão a ser cadastrada</param>
    /// <returns></returns>
    [HttpPost]
    [Produces<PlantacaoModel>]
    public async Task<IActionResult> Create([FromBody] PlantacaoDTO body)
    {
        var plantacao = new PlantacaoModel
        {
            CnpjProdutor = body.CnpjProdutor,
            NomeProdutor = body.NomeProdutor,
            RegiaoId = body.RegiaoId,
            TamanhoEmHectares = body.TamanhoEmHectares,
        };
   
        var result = await _plantacaoService.InsertAsync(plantacao);
        return result ? BadRequest() : Ok(plantacao);
    }

    /// <summary>
    /// Rota utilizada para atualizar uma plantacão
    /// </summary>
    /// <param name="id">Id da plantacão</param>
    /// <param name="body">Dados da plantacão</param>
    /// <returns></returns>
    [HttpPut("{id}")]
    [Produces<PlantacaoModel>]
    public async Task<IActionResult> Update(Guid id, [FromBody] PlantacaoDTO body)
    {
        var plantacao = new PlantacaoModel
        {
            CnpjProdutor = body.CnpjProdutor,
            NomeProdutor = body.NomeProdutor,
            RegiaoId = body.RegiaoId,
            TamanhoEmHectares = body.TamanhoEmHectares,
        };

        var result = await _plantacaoService.UpdateAsync(id, plantacao);
        return result ? NotFound() : Ok(body);
    }

    /// <summary>
    /// Rota utilizada para deletar uma plantacão
    /// </summary>
    /// <param name="id">Id da plantacão</param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    [Produces<PlantacaoModel>]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _plantacaoService.DeleteAsync(id);
        return result ? NotFound() : Ok();
    }
}
