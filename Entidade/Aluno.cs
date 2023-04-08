using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entidade
{
    [Table("aluno")]
    public class Aluno
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("alunoid")]
        public int AlunoId { get; set; }

        [Required]
        [Column("cpf")]
        [StringLength(20)]
        public string? Cpf { get; set; }

        [Required]
        [Column("nome")]
        [StringLength(100)]
        public string? Nome { get; set; }

        [Required]
        [Column("matricula")]
        public int Matricula { get; set; }

        [Required]
        [Column("email")]
        [StringLength(200)]
        public string? Email { get; set; }

        [Required]
        [Column("telefone")]
        [StringLength(20)]
        public string? Telefone { get; set; }

        [NotMapped]
        public ICollection<AtividadeComplementar>? AtividadesComplentares{ get; set; }
    }
}
