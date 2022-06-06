using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nucleo.Migrations
{
    public partial class AddProvincias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT [dbo].[Provincias] ON");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (1, 'A Coruña')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (2, 'Alicante')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (3, 'Albacete')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (4, 'Almería')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (5, 'Álava')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (6, 'Asturias')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (7, 'Ávila')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (8, 'Badajoz')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (9, 'Barcelona')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (10, 'Vizcaya')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (11, 'Burgos')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (12, 'Cáceres')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (13, 'Cádiz')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (14, 'Cantabria')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (15, 'Castellón')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (16, 'Ceuta')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (17, 'Ciudad Real')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (18, 'Córdoba')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (19, 'Cuenca')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (20, 'Guipúzcua')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (21, 'Gerona')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (22, 'Granada')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (23, 'Guadalajara')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (24, 'Huelva')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (25, 'Huesca')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (26, 'Islas Baleares')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (27, 'Jaén')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (28, 'La Rioja')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (29, 'Las Palmas')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (30, 'León')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (31, 'Lleida')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (32, 'Lugo')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (33, 'Madrid')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (34, 'Málaga')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (35, 'Melilla')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (36, 'Murcia')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (37, 'Navarra')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (38, 'Orense')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (39, 'Palencia')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (40, 'Pontevedra')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (41, 'Salamanca')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (42, 'Santa Cruz de Tenerife')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (43, 'Segovia')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (44, 'Sevilla')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (45, 'Soria')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (46, 'Tarragona')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (47, 'Teruel')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (48, 'Toledo')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (49, 'Valencia')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (50, 'Valladolid')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (51, 'Zamora')");
            migrationBuilder.Sql("Insert into Provincias (Id, Nombre) values (52, 'Zaragoza')");
            migrationBuilder.Sql("SET IDENTITY_INSERT [dbo].[Provincias] OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete  From Provincias Where Id > 0 and Id < 52");
        }
    }
}
