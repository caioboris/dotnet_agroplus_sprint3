using FIAP.Agroplus.Sprint3.Domain.Entities.Base;
using FIAP.Agroplus.Sprint3.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIAP.Agroplus.Sprint3.Domain.Entities;

[Table("T_REGIAO")]
public class RegiaoEntity : BaseEntity
{
    [Column("NOME")]
    [MaxLength(200)]
    public string Nome { get; set; } = string.Empty;

    [Column("REGIAO_BRASIL")]
    public RegiaoBR RegiaoBR { get; set; }

    [Column("PLANTIO_FREQUENTE")]
    public string PlantioMaisFrequente { get; set; } = string.Empty;

    [Column("TEMPERATURA_MEDIA")]
    public decimal TemperaturaMedia { get; set; }

    [Column("PRECIPITACAO_MEDIA")]
    public decimal PrecipitacaoMedia { get; set; }
}