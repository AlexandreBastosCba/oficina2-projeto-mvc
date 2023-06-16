using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorio.Migrations
{
    /// <inheritdoc />
    public partial class CorrigindoPropriedadeParaArquivos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "arquivo",
                table: "atividadecomplementar",
                type: "longblob",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 2147483647);

            migrationBuilder.AddColumn<string>(
                name: "NomeArquivo",
                table: "atividadecomplementar",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeArquivo",
                table: "atividadecomplementar");

            migrationBuilder.AlterColumn<int>(
                name: "arquivo",
                table: "atividadecomplementar",
                type: "int",
                maxLength: 2147483647,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(byte[]),
                oldType: "longblob",
                oldNullable: true);
        }
    }
}
