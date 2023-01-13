using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymSharpBerceaAneliseProiect.Migrations
{
    /// <inheritdoc />
    public partial class AddLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                 name: "Level",
                 table: "Workouts",
                 nullable: true
                 );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
  
        }
    }
}
