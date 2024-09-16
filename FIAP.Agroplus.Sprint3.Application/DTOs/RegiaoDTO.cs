namespace FIAP.Agroplus.Sprint3.Application.DTOs;

public record RegiaoDTO
{
    public string Nome { get; set; } = string.Empty;
    public string RegiaoBR { get; set; } = string.Empty;
    public string PlantioMaisFrequente { get; set; } = string.Empty;
    public decimal TemperaturaMedia { get; set; }
    public decimal PrecipitacaoMedia { get; set; }
}
