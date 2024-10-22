using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MercanlarApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Araclar",
                columns: table => new
                {
                    Plaka = table.Column<string>(type: "TEXT", nullable: false),
                    Sofor = table.Column<string>(type: "TEXT", nullable: false),
                    Sube = table.Column<string>(type: "TEXT", nullable: false),
                    Per = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Araclar", x => x.Plaka);
                });

            migrationBuilder.CreateTable(
                name: "Kargolar",
                columns: table => new
                {
                    CariNo = table.Column<string>(type: "TEXT", nullable: false),
                    Tip = table.Column<string>(type: "TEXT", nullable: false),
                    Evrak = table.Column<string>(type: "TEXT", nullable: false),
                    Tarih = table.Column<string>(type: "TEXT", nullable: false),
                    Unvan = table.Column<string>(type: "TEXT", nullable: false),
                    Resim = table.Column<string>(type: "TEXT", nullable: false),
                    Imza = table.Column<string>(type: "TEXT", nullable: false),
                    Teslim_Tarihi = table.Column<string>(type: "TEXT", nullable: false),
                    Teslim_Alan = table.Column<string>(type: "TEXT", nullable: false),
                    Islem = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kargolar", x => x.CariNo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Araclar");

            migrationBuilder.DropTable(
                name: "Kargolar");
        }
    }
}
