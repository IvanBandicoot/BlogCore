using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCore.AccesoDatos.Migrations
{
    public partial class spGetCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedimiento = @"create procedure spGetCategorias
                                    as
                                    begin
	                                    select * from Categoria
                                    end";
            migrationBuilder.Sql(procedimiento);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedimiento = @"drop procedure spGetCategorias";
            migrationBuilder.Sql(procedimiento);
        }
    }
}
