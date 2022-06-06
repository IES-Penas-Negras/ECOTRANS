using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nucleo.Migrations
{
    public partial class AñadirRolAdministrador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.Sql("SET IDENTITY_INSERT [dbo].[AspNetRoles] ON");
            migrationBuilder.Sql("Insert into AspNetRoles (Id, Name) values (1, 'Administrador')");
             migrationBuilder.Sql("SET IDENTITY_INSERT [dbo].[AspNetRoles] OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
