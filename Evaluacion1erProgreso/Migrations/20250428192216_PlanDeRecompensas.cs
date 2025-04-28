using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Evaluacion1erProgreso.Migrations
{
    /// <inheritdoc />
    public partial class PlanDeRecompensas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PlanDeRecompensas",
                newName: "PlanDeRecompensasId");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "FechaDeInicio",
                table: "Reserva",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "FechaDeFin",
                table: "Reserva",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "FechaDeCreacion",
                table: "Reserva",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "FechaCreacion",
                table: "PlanDeRecompensas",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "FechaCreacion",
                table: "Cliente",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "PlanDeRecompensasId",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PlanDeRecompensasId",
                table: "Cliente",
                column: "PlanDeRecompensasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_PlanDeRecompensas_PlanDeRecompensasId",
                table: "Cliente",
                column: "PlanDeRecompensasId",
                principalTable: "PlanDeRecompensas",
                principalColumn: "PlanDeRecompensasId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_PlanDeRecompensas_PlanDeRecompensasId",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_PlanDeRecompensasId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "PlanDeRecompensasId",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "PlanDeRecompensasId",
                table: "PlanDeRecompensas",
                newName: "Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaDeInicio",
                table: "Reserva",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaDeFin",
                table: "Reserva",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaDeCreacion",
                table: "Reserva",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "PlanDeRecompensas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }
    }
}
