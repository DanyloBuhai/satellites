using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace satellites.Migrations
{
    /// <inheritdoc />
    public partial class satel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planet",
                columns: table => new
                {
                    planet_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    planet_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planet", x => x.planet_id);
                });

            migrationBuilder.CreateTable(
                name: "Satelite",
                columns: table => new
                {
                    satellite_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    satellite_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    discovery_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diameter = table.Column<double>(type: "float", nullable: false),
                    turnover_period = table.Column<double>(type: "float", nullable: false),
                    atmosphere = table.Column<bool>(type: "bit", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    longnote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    planet_id1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satelite", x => x.satellite_id);
                    table.ForeignKey(
                        name: "FK_Satelite_Planet_planet_id1",
                        column: x => x.planet_id1,
                        principalTable: "Planet",
                        principalColumn: "planet_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Satelite_planet_id1",
                table: "Satelite",
                column: "planet_id1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Satelite");

            migrationBuilder.DropTable(
                name: "Planet");
        }
    }
}
