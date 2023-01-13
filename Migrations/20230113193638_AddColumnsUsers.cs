using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymSharpBerceaAneliseProiect.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnsUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.AddColumn<int>(name: "Age",table: "Users",nullable: true,defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Users",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Users",
                nullable: true,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
       
        }
    }
}
