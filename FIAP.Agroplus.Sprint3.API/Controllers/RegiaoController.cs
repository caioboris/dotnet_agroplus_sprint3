using FIAP.Agroplus.Sprint3.Application.DTOs;
using FIAP.Agroplus.Sprint3.Application.Models;
using FIAP.Agroplus.Sprint3.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FIAP.Agroplus.Sprint3.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RegiaoController : ControllerBase
{

    private readonly IRegiaoService _regiaoService;

    public RegiaoController(IRegiaoService regiaoService)
    {
        _regiaoService = regiaoService;
    }

    /// <summary>
    /// Rota utilizada para obter uma região a partir do seu id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    [Produces<RegiaoModel>]
    public async Task<IActionResult> GetById(Guid id)
    {
        var regiao = await _regiaoService.GetAsync(id);
        return regiao == null ? BadRequest() : Ok(regiao);
    }

    /// <summary>
    /// Rota utilizada para obter todas as regiões
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Produces<IEnumerable<RegiaoModel>>]
    public async Task<IActionResult> GetAll()
    {
        var regiao = await _regiaoService.GetAllAsync();
        return regiao == null ? BadRequest() : Ok(regiao);
    }

    /// <summary>
    /// Rota utilizada para cadastrar uma região
    /// </summary>
    /// <param name="body">Nova região a ser cadastrada</param>
    /// <returns></returns>
    [HttpPost]
    [Produces<RegiaoModel>]
    public async Task<IActionResult> Create([FromBody] RegiaoDTO body)
    {
        var regiao = new RegiaoModel
        {
            Nome = body.Nome,
            PlantioMaisFrequente = body.PlantioMaisFrequente,
            PrecipitacaoMedia = body.PrecipitacaoMedia,
            RegiaoBR = body.RegiaoBR,
            TemperaturaMedia = body.TemperaturaMedia    
        };
   
        var result = await _regiaoService.InsertAsync(regiao);
        return result ? Ok(regiao) : BadRequest();
    }

    /// <summary>
    /// Rota utilizada para atualizar uma região
    /// </summary>
    /// <param name="id">Id da região</param>
    /// <param name="body">Dados da região</param>
    /// <returns></returns>
    [HttpPut("{id}")]
    [Produces<RegiaoModel>]
    public async Task<IActionResult> Update(Guid id, [FromBody] RegiaoDTO body)
    {
        var regiao = new RegiaoModel
        {
            Nome = body.Nome,
            PlantioMaisFrequente = body.PlantioMaisFrequente,
            PrecipitacaoMedia = body.PrecipitacaoMedia,
            RegiaoBR = body.RegiaoBR,
            TemperaturaMedia = body.TemperaturaMedia
        };

        var result = await _regiaoService.UpdateAsync(id, regiao);
        return result ? Ok(body) : NotFound();
    }

    /// <summary>
    /// Rota utilizada para deletar uma região
    /// </summary>
    /// <param name="id">Id da região</param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    [Produces<RegiaoModel>]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _regiaoService.DeleteAsync(id);
        return result ? Ok() : NotFound() ;
    }
}
