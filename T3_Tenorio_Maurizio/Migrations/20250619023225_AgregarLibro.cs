using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace T3_Tenorio_Maurizio.Migrations
{
    /// <inheritdoc />
    public partial class AgregarLibro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "libro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tema = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Editorial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnioPublicacion = table.Column<int>(type: "int", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Paginas = table.Column<int>(type: "int", nullable: false),
                    Copias = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libro", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "libro");
        }
    }
}
