using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nucleo.Migrations
{
    public partial class AñadidaRelacinObjetoDonacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Objetos_TipoObjeto_TipoObjetoId",
                table: "Objetos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoObjeto",
                table: "TipoObjeto");

            migrationBuilder.RenameTable(
                name: "TipoObjeto",
                newName: "TiposObjetos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposObjetos",
                table: "TiposObjetos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ObjetoDonacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjetoId = table.Column<int>(type: "int", nullable: false),
                    DonacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjetoDonacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObjetoDonacion_Donaciones_DonacionId",
                        column: x => x.DonacionId,
                        principalTable: "Donaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjetoDonacion_Objetos_ObjetoId",
                        column: x => x.ObjetoId,
                        principalTable: "Objetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ObjetoDonacion_DonacionId",
                table: "ObjetoDonacion",
                column: "DonacionId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjetoDonacion_ObjetoId",
                table: "ObjetoDonacion",
                column: "ObjetoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Objetos_TiposObjetos_TipoObjetoId",
                table: "Objetos",
                column: "TipoObjetoId",
                principalTable: "TiposObjetos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Objetos_TiposObjetos_TipoObjetoId",
                table: "Objetos");

            migrationBuilder.DropTable(
                name: "ObjetoDonacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposObjetos",
                table: "TiposObjetos");

            migrationBuilder.RenameTable(
                name: "TiposObjetos",
                newName: "TipoObjeto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoObjeto",
                table: "TipoObjeto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Objetos_TipoObjeto_TipoObjetoId",
                table: "Objetos",
                column: "TipoObjetoId",
                principalTable: "TipoObjeto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
