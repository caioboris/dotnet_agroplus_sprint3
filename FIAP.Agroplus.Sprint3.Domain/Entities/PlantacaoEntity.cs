using FIAP.Agroplus.Sprint3.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIAP.Agroplus.Sprint3.Domain.Entities;

[Table("T_PLANTACAO")]
public class PlantacaoEntity : BaseEntity
{
    public Guid RegiaoId { get; set; }
    public RegiaoEntity Regiao { get; set; } = new();

    [Column("NOME_PRODUTO")]
    [MaxLength(200)]
    public string NomeProdutor { get; set; } = string.Empty;

    [Column("CNPJ_PRODUTO")]
    [MaxLength(14)]
    public string CnpjProdutor { get; set; } = string.Empty;

    [Column("TAMANHO_EM_HECTARES")]
    public decimal TamanhoEmHectares { get; set; }
}
