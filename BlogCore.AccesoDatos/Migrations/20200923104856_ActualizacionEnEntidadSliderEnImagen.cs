using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCore.AccesoDatos.Migrations
{
    public partial class ActualizacionEnEntidadSliderEnImagen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "urlImagen",
                table: "Slider",
                newName: "UrlImagen");

            migrationBuilder.AlterColumn<string>(
                name: "UrlImagen",
                table: "Slider",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UrlImagen",
                table: "Slider",
                newName: "urlImagen");

            migrationBuilder.AlterColumn<string>(
                name: "urlImagen",
                table: "Slider",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
