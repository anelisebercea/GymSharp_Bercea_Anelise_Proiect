using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymSharpBerceaAneliseProiect.Migrations
{
    /// <inheritdoc />
    public partial class AddDifficultyLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>( name: "DifficultyLevel", table: "Exercises", nullable: true);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
