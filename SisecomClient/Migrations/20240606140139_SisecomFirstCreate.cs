using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisecomClient.Migrations
{
    /// <inheritdoc />
    public partial class SisecomFirstCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<double>(type: "float", nullable: false),
                    PfPj = table.Column<bool>(type: "bit", nullable: false),
                    CpfCnpj = table.Column<double>(type: "float", nullable: false),
                    RgIe = table.Column<double>(type: "float", nullable: false),
                    NomeOuRazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeAbreviadoOuNomeFantasia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
