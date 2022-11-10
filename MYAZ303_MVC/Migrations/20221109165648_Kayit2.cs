using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MYAZ303MVC.Migrations
{
    /// <inheritdoc />
    public partial class Kayit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albumler");

            migrationBuilder.DropTable(
                name: "Sanatcilar");

            migrationBuilder.AddColumn<string>(
                name: "album",
                table: "Sarkilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sanatci",
                table: "Sarkilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "album",
                table: "Sarkilar");

            migrationBuilder.DropColumn(
                name: "sanatci",
                table: "Sarkilar");

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
                    albumID = table.Column<int>(type: "int", nullable: false),
                    sanatciAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanatcilar", x => x.sanatciID);
                });
        }
    }
}
