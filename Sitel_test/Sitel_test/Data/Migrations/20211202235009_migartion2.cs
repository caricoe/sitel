using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sitel_test.Data.Migrations
{
    public partial class migartion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Campaign_TrainerId",
                table: "Campaign");

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_TrainerId",
                table: "Campaign",
                column: "TrainerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Campaign_TrainerId",
                table: "Campaign");

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_TrainerId",
                table: "Campaign",
                column: "TrainerId",
                unique: true);
        }
    }
}
