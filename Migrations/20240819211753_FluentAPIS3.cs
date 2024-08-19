using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPIS3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_topic_courses_CourseIDId",
                table: "topic");

            migrationBuilder.AlterColumn<int>(
                name: "CourseIDId",
                table: "topic",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_topic_courses_CourseIDId",
                table: "topic",
                column: "CourseIDId",
                principalTable: "courses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_topic_courses_CourseIDId",
                table: "topic");

            migrationBuilder.AlterColumn<int>(
                name: "CourseIDId",
                table: "topic",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_topic_courses_CourseIDId",
                table: "topic",
                column: "CourseIDId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
