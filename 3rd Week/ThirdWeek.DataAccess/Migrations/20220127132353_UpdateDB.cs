using Microsoft.EntityFrameworkCore.Migrations;

namespace ThirdWeek.DataAccess.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Sellers_SellerID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_SellerID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "SellerID",
                table: "Comments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SellerID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_SellerID",
                table: "Comments",
                column: "SellerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Sellers_SellerID",
                table: "Comments",
                column: "SellerID",
                principalTable: "Sellers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
