using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorio.Migrations
{
    /// <inheritdoc />
    public partial class AjustandoPropriedades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_atividadecomplementar_aluno_alunoid",
                table: "atividadecomplementar");

            migrationBuilder.DropForeignKey(
                name: "FK_atividadecomplementar_tipoatividade_tipoatividadeid",
                table: "atividadecomplementar");

            migrationBuilder.DropIndex(
                name: "IX_atividadecomplementar_alunoid",
                table: "atividadecomplementar");

            migrationBuilder.DropIndex(
                name: "IX_atividadecomplementar_tipoatividadeid",
                table: "atividadecomplementar");

            migrationBuilder.RenameColumn(
                name: "NomeArquivo",
                table: "atividadecomplementar",
                newName: "nomearquivo");

            migrationBuilder.AddColumn<int>(
                name: "alunoid1",
                table: "atividadecomplementar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tipoatividadeid1",
                table: "atividadecomplementar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_atividadecomplementar_alunoid1",
                table: "atividadecomplementar",
                column: "alunoid1");

            migrationBuilder.CreateIndex(
                name: "IX_atividadecomplementar_tipoatividadeid1",
                table: "atividadecomplementar",
                column: "tipoatividadeid1");

            migrationBuilder.AddForeignKey(
                name: "FK_atividadecomplementar_aluno_alunoid1",
                table: "atividadecomplementar",
                column: "alunoid1",
                principalTable: "aluno",
                principalColumn: "alunoid");

            migrationBuilder.AddForeignKey(
                name: "FK_atividadecomplementar_tipoatividade_tipoatividadeid1",
                table: "atividadecomplementar",
                column: "tipoatividadeid1",
                principalTable: "tipoatividade",
                principalColumn: "tipoatividadeid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_atividadecomplementar_aluno_alunoid1",
                table: "atividadecomplementar");

            migrationBuilder.DropForeignKey(
                name: "FK_atividadecomplementar_tipoatividade_tipoatividadeid1",
                table: "atividadecomplementar");

            migrationBuilder.DropIndex(
                name: "IX_atividadecomplementar_alunoid1",
                table: "atividadecomplementar");

            migrationBuilder.DropIndex(
                name: "IX_atividadecomplementar_tipoatividadeid1",
                table: "atividadecomplementar");

            migrationBuilder.DropColumn(
                name: "alunoid1",
                table: "atividadecomplementar");

            migrationBuilder.DropColumn(
                name: "tipoatividadeid1",
                table: "atividadecomplementar");

            migrationBuilder.RenameColumn(
                name: "nomearquivo",
                table: "atividadecomplementar",
                newName: "NomeArquivo");

            migrationBuilder.CreateIndex(
                name: "IX_atividadecomplementar_alunoid",
                table: "atividadecomplementar",
                column: "alunoid");

            migrationBuilder.CreateIndex(
                name: "IX_atividadecomplementar_tipoatividadeid",
                table: "atividadecomplementar",
                column: "tipoatividadeid");

            migrationBuilder.AddForeignKey(
                name: "FK_atividadecomplementar_aluno_alunoid",
                table: "atividadecomplementar",
                column: "alunoid",
                principalTable: "aluno",
                principalColumn: "alunoid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_atividadecomplementar_tipoatividade_tipoatividadeid",
                table: "atividadecomplementar",
                column: "tipoatividadeid",
                principalTable: "tipoatividade",
                principalColumn: "tipoatividadeid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
