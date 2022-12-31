using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Complaints.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeCompNoteComplaintrel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompId",
                table: "EmployeeCompNotes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpCompNoteId",
                table: "Complaints",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCompNotes_CompId",
                table: "EmployeeCompNotes",
                column: "CompId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_EmpCompNoteId",
                table: "Complaints",
                column: "EmpCompNoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Complaints_EmployeeCompNotes_EmpCompNoteId",
                table: "Complaints",
                column: "EmpCompNoteId",
                principalTable: "EmployeeCompNotes",
                principalColumn: "EmpCompNoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCompNotes_Complaints_CompId",
                table: "EmployeeCompNotes",
                column: "CompId",
                principalTable: "Complaints",
                principalColumn: "CompId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complaints_EmployeeCompNotes_EmpCompNoteId",
                table: "Complaints");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCompNotes_Complaints_CompId",
                table: "EmployeeCompNotes");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeCompNotes_CompId",
                table: "EmployeeCompNotes");

            migrationBuilder.DropIndex(
                name: "IX_Complaints_EmpCompNoteId",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "CompId",
                table: "EmployeeCompNotes");

            migrationBuilder.DropColumn(
                name: "EmpCompNoteId",
                table: "Complaints");
        }
    }
}
