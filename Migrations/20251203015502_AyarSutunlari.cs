using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanalGozluk.Migrations
{
    /// <inheritdoc />
    public partial class AyarSutunlari : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Gozlukler",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Rotation",
                table: "Gozlukler",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Scale",
                table: "Gozlukler",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Gozlukler");

            migrationBuilder.DropColumn(
                name: "Rotation",
                table: "Gozlukler");

            migrationBuilder.DropColumn(
                name: "Scale",
                table: "Gozlukler");
        }
    }
}
