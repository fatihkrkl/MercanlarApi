using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MercanlarApi.Migrations
{
    /// <inheritdoc />
    public partial class YourMigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AracList",
                columns: table => new
                {
                    Plaka = table.Column<string>(type: "TEXT", nullable: false),
                    Sofor = table.Column<string>(type: "TEXT", nullable: false),
                    Sube = table.Column<string>(type: "TEXT", nullable: false),
                    Per = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AracList", x => x.Plaka);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AracList");
        }
    }
}
