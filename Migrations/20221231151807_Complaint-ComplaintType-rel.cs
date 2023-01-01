using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Complaints.Migrations
{
    /// <inheritdoc />
    public partial class ComplaintComplaintTyperel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompTypeId",
                table: "Complaints",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_CompTypeId",
                table: "Complaints",
                column: "CompTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Complaints_ComplaintTypes_CompTypeId",
                table: "Complaints",
                column: "CompTypeId",
                principalTable: "ComplaintTypes",
                principalColumn: "CompTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complaints_ComplaintTypes_CompTypeId",
                table: "Complaints");

            migrationBuilder.DropIndex(
                name: "IX_Complaints_CompTypeId",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "CompTypeId",
                table: "Complaints");
        }
    }
}
