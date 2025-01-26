using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tolist.Migrations
{
    /// <inheritdoc />
    public partial class UpgadeTbTarefa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Ambiente_AmbienteId",
                table: "Tarefas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ambiente",
                table: "Ambiente");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Tarefas");

            migrationBuilder.RenameTable(
                name: "Ambiente",
                newName: "Ambientes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInicio",
                table: "Tarefas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFim",
                table: "Tarefas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ambientes",
                table: "Ambientes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Ambientes_AmbienteId",
                table: "Tarefas",
                column: "AmbienteId",
                principalTable: "Ambientes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Ambientes_AmbienteId",
                table: "Tarefas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ambientes",
                table: "Ambientes");

            migrationBuilder.RenameTable(
                name: "Ambientes",
                newName: "Ambiente");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInicio",
                table: "Tarefas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFim",
                table: "Tarefas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Tarefas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ambiente",
                table: "Ambiente",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Ambiente_AmbienteId",
                table: "Tarefas",
                column: "AmbienteId",
                principalTable: "Ambiente",
                principalColumn: "Id");
        }
    }
}
