using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Complaints.Migrations
{
    /// <inheritdoc />
    public partial class complaintcitizenrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CtzId",
                table: "Complaints",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_CtzId",
                table: "Complaints",
                column: "CtzId");

            migrationBuilder.AddForeignKey(
                name: "FK_Complaints_Citizens_CtzId",
                table: "Complaints",
                column: "CtzId",
                principalTable: "Citizens",
                principalColumn: "CtzId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complaints_Citizens_CtzId",
                table: "Complaints");

            migrationBuilder.DropIndex(
                name: "IX_Complaints_CtzId",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "CtzId",
                table: "Complaints");
        }
    }
}
