using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.Infrastructure.Migrations
{
    public partial class addregisterddate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RegisteredDate",
                table: "Patients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GetPatientStatisticsDto",
                columns: table => new
                {
                    TotalPatients = table.Column<int>(type: "int", nullable: false),
                    NewPatientsToday = table.Column<int>(type: "int", nullable: false),
                    NewPatientsThisWeek = table.Column<int>(type: "int", nullable: false),
                    ActivePatients = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GetPatientStatisticsDto");

            migrationBuilder.DropColumn(
                name: "RegisteredDate",
                table: "Patients");
        }
    }
}
