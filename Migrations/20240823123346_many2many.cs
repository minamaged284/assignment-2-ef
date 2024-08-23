using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class many2many : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseIns_courses_courseID",
                table: "CourseIns");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseIns_instructors_InstructorId",
                table: "CourseIns");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_courses_courseID",
                table: "StudCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_students_StudentID",
                table: "StudCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudCourse",
                table: "StudCourse");

            migrationBuilder.DropIndex(
                name: "IX_StudCourse_StudentID",
                table: "StudCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseIns",
                table: "CourseIns");

            migrationBuilder.DropColumn(
                name: "StuID",
                table: "StudCourse");

            migrationBuilder.DropColumn(
                name: "InsID",
                table: "CourseIns");

            migrationBuilder.RenameColumn(
                name: "courseID",
                table: "StudCourse",
                newName: "CourseID");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "CourseIns",
                newName: "InstructorID");

            migrationBuilder.RenameColumn(
                name: "courseID",
                table: "CourseIns",
                newName: "CourseID");

            migrationBuilder.RenameIndex(
                name: "IX_CourseIns_InstructorId",
                table: "CourseIns",
                newName: "IX_CourseIns_InstructorID");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "StudCourse",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InstructorID",
                table: "CourseIns",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudCourse",
                table: "StudCourse",
                columns: new[] { "StudentID", "CourseID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseIns",
                table: "CourseIns",
                columns: new[] { "CourseID", "InstructorID" });

            migrationBuilder.CreateIndex(
                name: "IX_StudCourse_CourseID",
                table: "StudCourse",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseIns_courses_CourseID",
                table: "CourseIns",
                column: "CourseID",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseIns_instructors_InstructorID",
                table: "CourseIns",
                column: "InstructorID",
                principalTable: "instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_courses_CourseID",
                table: "StudCourse",
                column: "CourseID",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_students_StudentID",
                table: "StudCourse",
                column: "StudentID",
                principalTable: "students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseIns_courses_CourseID",
                table: "CourseIns");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseIns_instructors_InstructorID",
                table: "CourseIns");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_courses_CourseID",
                table: "StudCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_students_StudentID",
                table: "StudCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudCourse",
                table: "StudCourse");

            migrationBuilder.DropIndex(
                name: "IX_StudCourse_CourseID",
                table: "StudCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseIns",
                table: "CourseIns");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "StudCourse",
                newName: "courseID");

            migrationBuilder.RenameColumn(
                name: "InstructorID",
                table: "CourseIns",
                newName: "InstructorId");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "CourseIns",
                newName: "courseID");

            migrationBuilder.RenameIndex(
                name: "IX_CourseIns_InstructorID",
                table: "CourseIns",
                newName: "IX_CourseIns_InstructorId");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "StudCourse",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "StuID",
                table: "StudCourse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "InstructorId",
                table: "CourseIns",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "InsID",
                table: "CourseIns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudCourse",
                table: "StudCourse",
                columns: new[] { "courseID", "StuID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseIns",
                table: "CourseIns",
                columns: new[] { "courseID", "InsID" });

            migrationBuilder.CreateIndex(
                name: "IX_StudCourse_StudentID",
                table: "StudCourse",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseIns_courses_courseID",
                table: "CourseIns",
                column: "courseID",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseIns_instructors_InstructorId",
                table: "CourseIns",
                column: "InstructorId",
                principalTable: "instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_courses_courseID",
                table: "StudCourse",
                column: "courseID",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_students_StudentID",
                table: "StudCourse",
                column: "StudentID",
                principalTable: "students",
                principalColumn: "ID");
        }
    }
}
