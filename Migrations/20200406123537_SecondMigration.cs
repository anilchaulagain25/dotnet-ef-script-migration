using Microsoft.EntityFrameworkCore.Migrations;

namespace ScriptMigration.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OtherField",
                table: "FirstModel",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SecondModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondModel", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "FirstModel",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "VueJS");

            migrationBuilder.InsertData(
                table: "FirstModel",
                columns: new[] { "Id", "Name", "OtherField" },
                values: new object[] { 2, "Webpack", null });

            migrationBuilder.InsertData(
                table: "SecondModel",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Shankhu" },
                    { 2, "Bhumethumka" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SecondModel");

            migrationBuilder.DeleteData(
                table: "FirstModel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "OtherField",
                table: "FirstModel");

            migrationBuilder.UpdateData(
                table: "FirstModel",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Vue");
        }
    }
}
