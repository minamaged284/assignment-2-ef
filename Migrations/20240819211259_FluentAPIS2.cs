using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPIS2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_DeparttIDId",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_topic_courses_CouId",
                table: "topic");

            migrationBuilder.RenameColumn(
                name: "CouId",
                table: "topic",
                newName: "CourseIDId");

            migrationBuilder.RenameIndex(
                name: "IX_topic_CouId",
                table: "topic",
                newName: "IX_topic_CourseIDId");

            migrationBuilder.RenameColumn(
                name: "DeparttIDId",
                table: "students",
                newName: "DepartIDId");

            migrationBuilder.RenameIndex(
                name: "IX_students_DeparttIDId",
                table: "students",
                newName: "IX_students_DepartIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_DepartIDId",
                table: "students",
                column: "DepartIDId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_topic_courses_CourseIDId",
                table: "topic",
                column: "CourseIDId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_DepartIDId",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_topic_courses_CourseIDId",
                table: "topic");

            migrationBuilder.RenameColumn(
                name: "CourseIDId",
                table: "topic",
                newName: "CouId");

            migrationBuilder.RenameIndex(
                name: "IX_topic_CourseIDId",
                table: "topic",
                newName: "IX_topic_CouId");

            migrationBuilder.RenameColumn(
                name: "DepartIDId",
                table: "students",
                newName: "DeparttIDId");

            migrationBuilder.RenameIndex(
                name: "IX_students_DepartIDId",
                table: "students",
                newName: "IX_students_DeparttIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_DeparttIDId",
                table: "students",
                column: "DeparttIDId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_topic_courses_CouId",
                table: "topic",
                column: "CouId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
