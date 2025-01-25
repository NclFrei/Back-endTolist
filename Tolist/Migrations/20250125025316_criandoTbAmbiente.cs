using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tolist.Migrations
{
    /// <inheritdoc />
    public partial class criandoTbAmbiente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmbienteId",
                table: "Tarefas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ambiente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    icone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambiente", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_AmbienteId",
                table: "Tarefas",
                column: "AmbienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Ambiente_AmbienteId",
                table: "Tarefas",
                column: "AmbienteId",
                principalTable: "Ambiente",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Ambiente_AmbienteId",
                table: "Tarefas");

            migrationBuilder.DropTable(
                name: "Ambiente");

            migrationBuilder.DropIndex(
                name: "IX_Tarefas_AmbienteId",
                table: "Tarefas");

            migrationBuilder.DropColumn(
                name: "AmbienteId",
                table: "Tarefas");
        }
    }
}
