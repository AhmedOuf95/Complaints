using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Complaints.Migrations
{
    /// <inheritdoc />
    public partial class ComplaintComplaintFilerel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompId",
                table: "ComplaintFiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintFiles_CompId",
                table: "ComplaintFiles",
                column: "CompId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComplaintFiles_Complaints_CompId",
                table: "ComplaintFiles",
                column: "CompId",
                principalTable: "Complaints",
                principalColumn: "CompId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComplaintFiles_Complaints_CompId",
                table: "ComplaintFiles");

            migrationBuilder.DropIndex(
                name: "IX_ComplaintFiles_CompId",
                table: "ComplaintFiles");

            migrationBuilder.DropColumn(
                name: "CompId",
                table: "ComplaintFiles");
        }
    }
}
