using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class dataannotations1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_instructors_departments_DepartmenttIDId",
                table: "instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_DepartmentIDId",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_topic_courses_CourseId",
                table: "topic");

            migrationBuilder.DropIndex(
                name: "IX_students_DepartmentIDId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_instructors_DepartmenttIDId",
                table: "instructors");

            migrationBuilder.DropColumn(
                name: "DepartmentIDId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "DepartmenttIDId",
                table: "instructors");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "topic",
                newName: "CourseID");

            migrationBuilder.RenameIndex(
                name: "IX_topic_CourseId",
                table: "topic",
                newName: "IX_topic_CourseID");

            migrationBuilder.AddColumn<int>(
                name: "DeptID",
                table: "students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseIDId",
                table: "studCourse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "instructors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_DeptID",
                table: "students",
                column: "DeptID");

            migrationBuilder.CreateIndex(
                name: "IX_studCourse_CourseIDId",
                table: "studCourse",
                column: "CourseIDId");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_DepartmentID",
                table: "instructors",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_departments_DepartmentID",
                table: "instructors",
                column: "DepartmentID",
                principalTable: "departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_studCourse_courses_CourseIDId",
                table: "studCourse",
                column: "CourseIDId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_DeptID",
                table: "students",
                column: "DeptID",
                principalTable: "departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_topic_courses_CourseID",
                table: "topic",
                column: "CourseID",
                principalTable: "courses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_instructors_departments_DepartmentID",
                table: "instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_studCourse_courses_CourseIDId",
                table: "studCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_DeptID",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_topic_courses_CourseID",
                table: "topic");

            migrationBuilder.DropIndex(
                name: "IX_students_DeptID",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_studCourse_CourseIDId",
                table: "studCourse");

            migrationBuilder.DropIndex(
                name: "IX_instructors_DepartmentID",
                table: "instructors");

            migrationBuilder.DropColumn(
                name: "DeptID",
                table: "students");

            migrationBuilder.DropColumn(
                name: "CourseIDId",
                table: "studCourse");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "instructors");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "topic",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_topic_CourseID",
                table: "topic",
                newName: "IX_topic_CourseId");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentIDId",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmenttIDId",
                table: "instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_students_DepartmentIDId",
                table: "students",
                column: "DepartmentIDId");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_DepartmenttIDId",
                table: "instructors",
                column: "DepartmenttIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_departments_DepartmenttIDId",
                table: "instructors",
                column: "DepartmenttIDId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_DepartmentIDId",
                table: "students",
                column: "DepartmentIDId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_topic_courses_CourseId",
                table: "topic",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id");
        }
    }
}
