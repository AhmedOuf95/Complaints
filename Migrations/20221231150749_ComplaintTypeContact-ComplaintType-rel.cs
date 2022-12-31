using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Complaints.Migrations
{
    /// <inheritdoc />
    public partial class ComplaintTypeContactComplaintTyperel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeComplaint_Complaints_CompId",
                table: "EmployeeComplaint");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeComplaint_Employees_EmpId",
                table: "EmployeeComplaint");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeComplaint",
                table: "EmployeeComplaint");

            migrationBuilder.RenameTable(
                name: "EmployeeComplaint",
                newName: "EmployeeComplaints");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeComplaint_CompId",
                table: "EmployeeComplaints",
                newName: "IX_EmployeeComplaints_CompId");

            migrationBuilder.AlterColumn<string>(
                name: "CompTypeName",
                table: "ComplaintTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeComplaints",
                table: "EmployeeComplaints",
                columns: new[] { "EmpId", "CompId" });

            migrationBuilder.CreateTable(
                name: "ComplaintTypeContacts",
                columns: table => new
                {
                    CompTypeContactID = table.Column<int>(type: "int", nullable: false),
                    CompTypeId = table.Column<int>(type: "int", nullable: false),
                    CompTypeContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompTypeContactPhone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplaintTypeContacts", x => new { x.CompTypeContactID, x.CompTypeId });
                    table.ForeignKey(
                        name: "FK_ComplaintTypeContacts_ComplaintTypes_CompTypeId",
                        column: x => x.CompTypeId,
                        principalTable: "ComplaintTypes",
                        principalColumn: "CompTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintTypeContacts_CompTypeId",
                table: "ComplaintTypeContacts",
                column: "CompTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeComplaints_Complaints_CompId",
                table: "EmployeeComplaints",
                column: "CompId",
                principalTable: "Complaints",
                principalColumn: "CompId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeComplaints_Employees_EmpId",
                table: "EmployeeComplaints",
                column: "EmpId",
                principalTable: "Employees",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeComplaints_Complaints_CompId",
                table: "EmployeeComplaints");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeComplaints_Employees_EmpId",
                table: "EmployeeComplaints");

            migrationBuilder.DropTable(
                name: "ComplaintTypeContacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeComplaints",
                table: "EmployeeComplaints");

            migrationBuilder.RenameTable(
                name: "EmployeeComplaints",
                newName: "EmployeeComplaint");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeComplaints_CompId",
                table: "EmployeeComplaint",
                newName: "IX_EmployeeComplaint_CompId");

            migrationBuilder.AlterColumn<string>(
                name: "CompTypeName",
                table: "ComplaintTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeComplaint",
                table: "EmployeeComplaint",
                columns: new[] { "EmpId", "CompId" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeComplaint_Complaints_CompId",
                table: "EmployeeComplaint",
                column: "CompId",
                principalTable: "Complaints",
                principalColumn: "CompId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeComplaint_Employees_EmpId",
                table: "EmployeeComplaint",
                column: "EmpId",
                principalTable: "Employees",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
