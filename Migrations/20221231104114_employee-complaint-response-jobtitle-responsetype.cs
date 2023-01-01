using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Complaints.Migrations
{
    /// <inheritdoc />
    public partial class employeecomplaintresponsejobtitleresponsetype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Areas",
                newName: "AreaName");

            migrationBuilder.AddColumn<int>(
                name: "CompId",
                table: "Responses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RespTypeId",
                table: "Responses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobTitId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AreaId",
                table: "Complaints",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompStatusID",
                table: "Complaints",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EmployeeComplaint",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false),
                    CompId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeComplaint", x => new { x.EmpId, x.CompId });
                    table.ForeignKey(
                        name: "FK_EmployeeComplaint_Complaints_CompId",
                        column: x => x.CompId,
                        principalTable: "Complaints",
                        principalColumn: "CompId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeComplaint_Employees_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employees",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_CompId",
                table: "Responses",
                column: "CompId");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_RespTypeId",
                table: "Responses",
                column: "RespTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DeptId",
                table: "Employees",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeId",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobTitId",
                table: "Employees",
                column: "JobTitId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_AreaId",
                table: "Complaints",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_CompStatusID",
                table: "Complaints",
                column: "CompStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeComplaint_CompId",
                table: "EmployeeComplaint",
                column: "CompId");

            migrationBuilder.AddForeignKey(
                name: "FK_Complaints_Areas_AreaId",
                table: "Complaints",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "AreaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaints_ComplaintStatuses_CompStatusID",
                table: "Complaints",
                column: "CompStatusID",
                principalTable: "ComplaintStatuses",
                principalColumn: "CompStatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DeptId",
                table: "Employees",
                column: "DeptId",
                principalTable: "Departments",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_EmployeeId",
                table: "Employees",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobTitles_JobTitId",
                table: "Employees",
                column: "JobTitId",
                principalTable: "JobTitles",
                principalColumn: "JobTitleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Complaints_CompId",
                table: "Responses",
                column: "CompId",
                principalTable: "Complaints",
                principalColumn: "CompId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_ResponseTypes_RespTypeId",
                table: "Responses",
                column: "RespTypeId",
                principalTable: "ResponseTypes",
                principalColumn: "RespTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complaints_Areas_AreaId",
                table: "Complaints");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaints_ComplaintStatuses_CompStatusID",
                table: "Complaints");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DeptId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_EmployeeId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobTitles_JobTitId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Complaints_CompId",
                table: "Responses");

            migrationBuilder.DropForeignKey(
                name: "FK_Responses_ResponseTypes_RespTypeId",
                table: "Responses");

            migrationBuilder.DropTable(
                name: "EmployeeComplaint");

            migrationBuilder.DropIndex(
                name: "IX_Responses_CompId",
                table: "Responses");

            migrationBuilder.DropIndex(
                name: "IX_Responses_RespTypeId",
                table: "Responses");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DeptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_JobTitId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Complaints_AreaId",
                table: "Complaints");

            migrationBuilder.DropIndex(
                name: "IX_Complaints_CompStatusID",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "CompId",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "RespTypeId",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "JobTitId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AreaId",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "CompStatusID",
                table: "Complaints");

            migrationBuilder.RenameColumn(
                name: "AreaName",
                table: "Areas",
                newName: "Name");
        }
    }
}
