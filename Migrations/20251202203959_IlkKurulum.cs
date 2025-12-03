using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanalGozluk.Migrations
{
    /// <inheritdoc />
    public partial class IlkKurulum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gozlukler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: false),
                    Fiyat = table.Column<decimal>(type: "TEXT", nullable: false),
                    ResimUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Model3DUrl = table.Column<string>(type: "TEXT", nullable: false),
                    YuzTipi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gozlukler", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gozlukler");
        }
    }
}
