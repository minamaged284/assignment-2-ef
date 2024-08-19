using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPIS1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseIns_Course_COurseIDId",
                schema: "dbo",
                table: "CourseIns");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseIns_Instructor_InsIDId",
                schema: "dbo",
                table: "CourseIns");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Department_DepartmentID",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_Course_CourseIDId",
                schema: "dbo",
                table: "StudCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_Student_StuIDID",
                schema: "dbo",
                table: "StudCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_DeptID",
                schema: "dbo",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Course_CourseID",
                schema: "dbo",
                table: "Topic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topic",
                schema: "dbo",
                table: "Topic");

            migrationBuilder.DropIndex(
                name: "IX_Topic_CourseID",
                schema: "dbo",
                table: "Topic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                schema: "dbo",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_DeptID",
                schema: "dbo",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_DepartmentID",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                schema: "dbo",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                schema: "dbo",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "CourseID",
                schema: "dbo",
                table: "Topic");

            migrationBuilder.DropColumn(
                name: "DeptID",
                schema: "dbo",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.RenameTable(
                name: "Topic",
                schema: "dbo",
                newName: "topic");

            migrationBuilder.RenameTable(
                name: "Student",
                schema: "dbo",
                newName: "students");

            migrationBuilder.RenameTable(
                name: "Instructor",
                schema: "dbo",
                newName: "instructors");

            migrationBuilder.RenameTable(
                name: "Department",
                schema: "dbo",
                newName: "departments");

            migrationBuilder.RenameTable(
                name: "CourseIns",
                schema: "dbo",
                newName: "coursesIns");

            migrationBuilder.RenameTable(
                name: "Course",
                schema: "dbo",
                newName: "courses");

            migrationBuilder.RenameIndex(
                name: "IX_CourseIns_InsIDId",
                table: "coursesIns",
                newName: "IX_coursesIns_InsIDId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseIns_COurseIDId",
                table: "coursesIns",
                newName: "IX_coursesIns_COurseIDId");

            migrationBuilder.AddColumn<int>(
                name: "CouId",
                table: "topic",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeparttIDId",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartIdId",
                table: "instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_topic",
                table: "topic",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_instructors",
                table: "instructors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departments",
                table: "departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_courses",
                table: "courses",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_topic_CouId",
                table: "topic",
                column: "CouId");

            migrationBuilder.CreateIndex(
                name: "IX_students_DeparttIDId",
                table: "students",
                column: "DeparttIDId");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_DepartIdId",
                table: "instructors",
                column: "DepartIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_coursesIns_courses_COurseIDId",
                table: "coursesIns",
                column: "COurseIDId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_coursesIns_instructors_InsIDId",
                table: "coursesIns",
                column: "InsIDId",
                principalTable: "instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_departments_DepartIdId",
                table: "instructors",
                column: "DepartIdId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_courses_CourseIDId",
                schema: "dbo",
                table: "StudCourse",
                column: "CourseIDId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_students_StuIDID",
                schema: "dbo",
                table: "StudCourse",
                column: "StuIDID",
                principalTable: "students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_coursesIns_courses_COurseIDId",
                table: "coursesIns");

            migrationBuilder.DropForeignKey(
                name: "FK_coursesIns_instructors_InsIDId",
                table: "coursesIns");

            migrationBuilder.DropForeignKey(
                name: "FK_instructors_departments_DepartIdId",
                table: "instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_courses_CourseIDId",
                schema: "dbo",
                table: "StudCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_students_StuIDID",
                schema: "dbo",
                table: "StudCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_DeparttIDId",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_topic_courses_CouId",
                table: "topic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_topic",
                table: "topic");

            migrationBuilder.DropIndex(
                name: "IX_topic_CouId",
                table: "topic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_DeparttIDId",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_instructors",
                table: "instructors");

            migrationBuilder.DropIndex(
                name: "IX_instructors_DepartIdId",
                table: "instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departments",
                table: "departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_courses",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "CouId",
                table: "topic");

            migrationBuilder.DropColumn(
                name: "DeparttIDId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "DepartIdId",
                table: "instructors");

            migrationBuilder.RenameTable(
                name: "topic",
                newName: "Topic",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "students",
                newName: "Student",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "instructors",
                newName: "Instructor",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "departments",
                newName: "Department",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "coursesIns",
                newName: "CourseIns",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "courses",
                newName: "Course",
                newSchema: "dbo");

            migrationBuilder.RenameIndex(
                name: "IX_coursesIns_InsIDId",
                schema: "dbo",
                table: "CourseIns",
                newName: "IX_CourseIns_InsIDId");

            migrationBuilder.RenameIndex(
                name: "IX_coursesIns_COurseIDId",
                schema: "dbo",
                table: "CourseIns",
                newName: "IX_CourseIns_COurseIDId");

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                schema: "dbo",
                table: "Topic",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeptID",
                schema: "dbo",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                schema: "dbo",
                table: "Instructor",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topic",
                schema: "dbo",
                table: "Topic",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                schema: "dbo",
                table: "Student",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                schema: "dbo",
                table: "Instructor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                schema: "dbo",
                table: "Department",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                schema: "dbo",
                table: "Course",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Topic_CourseID",
                schema: "dbo",
                table: "Topic",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_DeptID",
                schema: "dbo",
                table: "Student",
                column: "DeptID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_DepartmentID",
                schema: "dbo",
                table: "Instructor",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseIns_Course_COurseIDId",
                schema: "dbo",
                table: "CourseIns",
                column: "COurseIDId",
                principalSchema: "dbo",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseIns_Instructor_InsIDId",
                schema: "dbo",
                table: "CourseIns",
                column: "InsIDId",
                principalSchema: "dbo",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Department_DepartmentID",
                schema: "dbo",
                table: "Instructor",
                column: "DepartmentID",
                principalSchema: "dbo",
                principalTable: "Department",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_Course_CourseIDId",
                schema: "dbo",
                table: "StudCourse",
                column: "CourseIDId",
                principalSchema: "dbo",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_Student_StuIDID",
                schema: "dbo",
                table: "StudCourse",
                column: "StuIDID",
                principalSchema: "dbo",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_DeptID",
                schema: "dbo",
                table: "Student",
                column: "DeptID",
                principalSchema: "dbo",
                principalTable: "Department",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Course_CourseID",
                schema: "dbo",
                table: "Topic",
                column: "CourseID",
                principalSchema: "dbo",
                principalTable: "Course",
                principalColumn: "Id");
        }
    }
}
