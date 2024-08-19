using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class dataannotations5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseIns_Employees_COurseIDId",
                schema: "dbo",
                table: "CourseIns");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_Employees_CourseIDId",
                schema: "dbo",
                table: "StudCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Employees_CourseID",
                schema: "dbo",
                table: "Topic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                schema: "dbo",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                schema: "dbo",
                newName: "Course",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                schema: "dbo",
                table: "Course",
                column: "Id");

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
                name: "FK_StudCourse_Course_CourseIDId",
                schema: "dbo",
                table: "StudCourse",
                column: "CourseIDId",
                principalSchema: "dbo",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Course_CourseID",
                schema: "dbo",
                table: "Topic",
                column: "CourseID",
                principalSchema: "dbo",
                principalTable: "Course",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseIns_Course_COurseIDId",
                schema: "dbo",
                table: "CourseIns");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_Course_CourseIDId",
                schema: "dbo",
                table: "StudCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Course_CourseID",
                schema: "dbo",
                table: "Topic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                schema: "dbo",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Course",
                schema: "dbo",
                newName: "Employees",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                schema: "dbo",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseIns_Employees_COurseIDId",
                schema: "dbo",
                table: "CourseIns",
                column: "COurseIDId",
                principalSchema: "dbo",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_Employees_CourseIDId",
                schema: "dbo",
                table: "StudCourse",
                column: "CourseIDId",
                principalSchema: "dbo",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Employees_CourseID",
                schema: "dbo",
                table: "Topic",
                column: "CourseID",
                principalSchema: "dbo",
                principalTable: "Employees",
                principalColumn: "Id");
        }
    }
}
