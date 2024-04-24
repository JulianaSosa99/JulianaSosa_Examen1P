using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JulianaSosa_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class JulianaSosaDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JS_Medicinas",
                columns: table => new
                {
                    JS_MedicinasID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JS_DescripcionMedicina = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    JS_FechaDeEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JS_ConReceta = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JS_Medicinas", x => x.JS_MedicinasID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JS_Medicinas");
        }
    }
}
