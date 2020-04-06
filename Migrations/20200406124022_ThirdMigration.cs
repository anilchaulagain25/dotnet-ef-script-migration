using Microsoft.EntityFrameworkCore.Migrations;

namespace ScriptMigration.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FirstModel",
                keyColumn: "Id",
                keyValue: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FirstModel",
                columns: new[] { "Id", "Name", "OtherField" },
                values: new object[] { 2, "Webpack", null });
        }
    }
}
