using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TecLog.Migrations
{
    /// <inheritdoc />
    public partial class Usuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<long>(type: "bigint", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Cpf", "CreatedAt", "Endereco", "Nome", "Senha", "Telefone", "UpdatedAt", "UserName" },
                values: new object[] { 1, 93260334068L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jaime silveira", "Brayam", "candidato123", 51992859570L, null, "SISTEMA" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
