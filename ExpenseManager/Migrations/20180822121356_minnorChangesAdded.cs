using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseManager.Migrations
{
    public partial class minnorChangesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemName",
                table: "ExpenseReport",
                newName: "Item name");

            migrationBuilder.RenameColumn(
                name: "ExpenseDate",
                table: "ExpenseReport",
                newName: "Expense date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Item name",
                table: "ExpenseReport",
                newName: "ItemName");

            migrationBuilder.RenameColumn(
                name: "Expense date",
                table: "ExpenseReport",
                newName: "ExpenseDate");
        }
    }
}
