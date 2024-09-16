using FIAP.Agroplus.Sprint3.Application.Models;

namespace FIAP.Agroplus.Sprint3.Application.DTOs;

public record PlantacaoDTO
{
    public Guid RegiaoId { get; set; }
    public RegiaoDTO Regiao { get; set; } = new();
    public string NomeProdutor { get; set; } = string.Empty;
    public string CnpjProdutor { get; set; } = string.Empty;
    public decimal TamanhoEmHectares { get; set; }

}
