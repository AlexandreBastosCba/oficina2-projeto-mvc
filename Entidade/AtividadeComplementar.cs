using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Entidade
{
    [Table("atividadecomplementar")]
    public class AtividadeComplementar
    {
        [Key]
        [Required]
        [Column("atividadecomplementarid")]
        public int AtividadeComplementarId { get; set; }

        [Required]
        [Column("alunoid")]
        public int AlunoId { get; set; }

        [Required]
        [Column("tipoatividadeid")]
        public int TipoAtividadeId { get; set; }

        [Required]
        [Column("descricaoatividade")]
        [StringLength(200)]
        public string? DescricaoAtividade { get; set; }

        [Required]
        [Column("cargahoraria")]
        public int CargaHoraria { get; set; }

        [Required]
        [Column("instituicao")]
        [StringLength(100)]
        public string? Institiuicao { get; set; }

        [Required]
        [Column("anoconclusao")]
        public int AnoConclusao { get; set; }


        [Column("arquivo")]
        [StringLength(int.MaxValue)]
        public int Arquivo { get; set; }


        [Column("observacao")]
        [StringLength(500)]
        public string? Observacao { get; set; }

        [ForeignKey("AlunoId")]
        public Aluno? Aluno { get; set; }

        [ForeignKey("TipoAtividadeId")]
        public TipoAtividade? TipoAtividade { get; set; }

    }
}
