using Microsoft.EntityFrameworkCore.Migrations;

namespace StarkFamily.Migrations
{
    public partial class FixForeignKeyFifthTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Persons_PersonId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PersonId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Persons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PersonId",
                table: "Persons",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Persons_PersonId",
                table: "Persons",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
