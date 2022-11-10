using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MYAZ303MVC.Migrations
{
    /// <inheritdoc />
    public partial class Kayit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albumler",
                columns: table => new
                {
                    albumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    albumAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sarkiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albumler", x => x.albumID);
                });

            migrationBuilder.CreateTable(
                name: "Sanatcilar",
                columns: table => new
                {
                    sanatciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sanatciAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    albumID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanatcilar", x => x.sanatciID);
                });

            migrationBuilder.CreateTable(
                name: "Sarkilar",
                columns: table => new
                {
                    sarkiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sarkiAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sure = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sarkilar", x => x.sarkiID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albumler");

            migrationBuilder.DropTable(
                name: "Sanatcilar");

            migrationBuilder.DropTable(
                name: "Sarkilar");
        }
    }
}
