using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymSharpBerceaAneliseProiect.Migrations
{
    /// <inheritdoc />
    public partial class AddExerciseID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

          

            migrationBuilder.AddColumn<int>(
                name: "Exercise_id",
                table: "Measurements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            

            migrationBuilder.AddForeignKey(
                name: "FK_Measurements_Exercises_Exercise_id",
                table: "Measurements",
                column: "Exercise_id",
                principalTable: "Exercises",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
