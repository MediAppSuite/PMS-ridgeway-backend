using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.Infrastructure.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientRecord_Reason_ReasonID",
                table: "PatientRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reason",
                table: "Reason");

            migrationBuilder.RenameTable(
                name: "Reason",
                newName: "Reasons");

            migrationBuilder.AlterColumn<bool>(
                name: "TranexamicAcidGivenOrNot",
                table: "PatientRecord",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Thyroid",
                table: "PatientRecord",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IschemicHeartDiseases",
                table: "PatientRecord",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Hypertension",
                table: "PatientRecord",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DM",
                table: "PatientRecord",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DLD",
                table: "PatientRecord",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reasons",
                table: "Reasons",
                column: "ReasonID");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientRecord_Reasons_ReasonID",
                table: "PatientRecord",
                column: "ReasonID",
                principalTable: "Reasons",
                principalColumn: "ReasonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientRecord_Reasons_ReasonID",
                table: "PatientRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reasons",
                table: "Reasons");

            migrationBuilder.RenameTable(
                name: "Reasons",
                newName: "Reason");

            migrationBuilder.AlterColumn<string>(
                name: "TranexamicAcidGivenOrNot",
                table: "PatientRecord",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Thyroid",
                table: "PatientRecord",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IschemicHeartDiseases",
                table: "PatientRecord",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Hypertension",
                table: "PatientRecord",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "DM",
                table: "PatientRecord",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DLD",
                table: "PatientRecord",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reason",
                table: "Reason",
                column: "ReasonID");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientRecord_Reason_ReasonID",
                table: "PatientRecord",
                column: "ReasonID",
                principalTable: "Reason",
                principalColumn: "ReasonID");
        }
    }
}
