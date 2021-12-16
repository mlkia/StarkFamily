using Microsoft.EntityFrameworkCore.Migrations;

namespace StarkFamily.Migrations
{
    public partial class Return : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Persons_MotherId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_MotherId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "MotherId",
                table: "Persons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MotherId",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MotherId",
                table: "Persons",
                column: "MotherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Persons_MotherId",
                table: "Persons",
                column: "MotherId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
