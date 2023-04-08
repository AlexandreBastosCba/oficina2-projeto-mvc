using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorio.Migrations
{
    /// <inheritdoc />
    public partial class PrimeirasTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "aluno",
                columns: table => new
                {
                    alunoid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cpf = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    matricula = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aluno", x => x.alunoid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipoatividade",
                columns: table => new
                {
                    tipoatividadeid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoatividade", x => x.tipoatividadeid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "atividadecomplementar",
                columns: table => new
                {
                    atividadecomplementarid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    alunoid = table.Column<int>(type: "int", nullable: false),
                    tipoatividadeid = table.Column<int>(type: "int", nullable: false),
                    descricaoatividade = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cargahoraria = table.Column<int>(type: "int", nullable: false),
                    instituicao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    anoconclusao = table.Column<int>(type: "int", nullable: false),
                    arquivo = table.Column<int>(type: "int", maxLength: 2147483647, nullable: false),
                    observacao = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_atividadecomplementar", x => x.atividadecomplementarid);
                    table.ForeignKey(
                        name: "FK_atividadecomplementar_aluno_alunoid",
                        column: x => x.alunoid,
                        principalTable: "aluno",
                        principalColumn: "alunoid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_atividadecomplementar_tipoatividade_tipoatividadeid",
                        column: x => x.tipoatividadeid,
                        principalTable: "tipoatividade",
                        principalColumn: "tipoatividadeid",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_atividadecomplementar_alunoid",
                table: "atividadecomplementar",
                column: "alunoid");

            migrationBuilder.CreateIndex(
                name: "IX_atividadecomplementar_tipoatividadeid",
                table: "atividadecomplementar",
                column: "tipoatividadeid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "atividadecomplementar");

            migrationBuilder.DropTable(
                name: "aluno");

            migrationBuilder.DropTable(
                name: "tipoatividade");
        }
    }
}
