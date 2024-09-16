namespace FIAP.Agroplus.Sprint3.Application.Models;

public class PlantacaoModel
{
    public Guid RegiaoId { get; set; }
    public RegiaoModel Regiao { get; set; } = new();
    public string NomeProdutor { get; set; } = string.Empty;
    public string CnpjProdutor { get; set; } = string.Empty;
    public decimal TamanhoEmHectares { get; set; }
}
