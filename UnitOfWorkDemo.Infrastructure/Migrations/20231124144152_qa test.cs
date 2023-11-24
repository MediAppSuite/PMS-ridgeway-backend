using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.Infrastructure.Migrations
{
    public partial class qatest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PatientTypeID",
                table: "PatientRecord");

            migrationBuilder.AlterColumn<long>(
                name: "BHTNumber",
                table: "PatientRecord",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "Diagnosis",
                table: "PatientRecord",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diagnosis",
                table: "PatientRecord");

            migrationBuilder.AlterColumn<long>(
                name: "BHTNumber",
                table: "PatientRecord",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientTypeID",
                table: "PatientRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
