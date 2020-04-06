using Microsoft.EntityFrameworkCore.Migrations;

namespace ScriptMigration.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FirstModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstModel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FirstModel",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Vue" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FirstModel");
        }
    }
}
