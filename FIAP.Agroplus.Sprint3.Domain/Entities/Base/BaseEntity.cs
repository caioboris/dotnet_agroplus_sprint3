using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIAP.Agroplus.Sprint3.Domain.Entities.Base;

public abstract class BaseEntity
{
    [Key]
    public Guid Id { get; set; }

    [Column("DATA_CRIACAO")]
    public DateTimeOffset DataCriacao { get; set; }

    [Column("DATA_ATUALIZACAO")]
    public DateTimeOffset DataAtualizacao { get; set; }
}
