using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidade
{
    [Table("tipoatividade")]
    public class TipoAtividade
    {
        [Key]
        [Required]
        [Column("tipoatividadeid")]
        public int TipoAtividadeId { get; set; }

        [Required]
        [Column("descricao")]
        public string? Descricao { get; set; }

    }
}