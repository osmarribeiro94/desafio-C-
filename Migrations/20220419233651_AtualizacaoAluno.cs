using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace challenge.Migrations
{
    public partial class AtualizacaoAluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "Alunos",
                newName: "tb_aluno");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tb_aluno",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Matricula",
                table: "tb_aluno",
                newName: "matricula");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_aluno",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DtNascimento",
                table: "tb_aluno",
                newName: "data_nascimento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_aluno",
                table: "tb_aluno",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_aluno",
                table: "tb_aluno");

            migrationBuilder.RenameTable(
                name: "tb_aluno",
                newName: "Alunos");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Alunos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "matricula",
                table: "Alunos",
                newName: "Matricula");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Alunos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "data_nascimento",
                table: "Alunos",
                newName: "DtNascimento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos",
                column: "Id");
        }
    }
}
