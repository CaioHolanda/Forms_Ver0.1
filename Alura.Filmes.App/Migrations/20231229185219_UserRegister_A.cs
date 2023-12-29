using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alura.Filmes.App.Migrations
{
    public partial class UserRegister_A : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Codigos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Conta = table.Column<string>(type: "varchar(50)", nullable: false),
                    Usuario = table.Column<string>(type: "varchar(50)", nullable: false),
                    Codigo = table.Column<string>(type: "varchar(50)", nullable: false),
                    UltimaAlteracao = table.Column<DateTime>(name: "Ultima Alteracao", type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Codigos", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Codigos");
        }
    }
}
