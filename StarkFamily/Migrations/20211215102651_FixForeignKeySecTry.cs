using Microsoft.EntityFrameworkCore.Migrations;

namespace StarkFamily.Migrations
{
    public partial class FixForeignKeySecTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Persons_FatherId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_FatherId",
                table: "Persons");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Persons_MotherId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_MotherId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "MotherId",
                table: "Persons");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_FatherId",
                table: "Persons",
                column: "FatherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Persons_FatherId",
                table: "Persons",
                column: "FatherId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
