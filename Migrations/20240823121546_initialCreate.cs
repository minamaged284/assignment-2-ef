using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HiringDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "topic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseIDId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_topic_courses_CourseIDId",
                        column: x => x.CourseIDId,
                        principalTable: "courses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HourRate = table.Column<int>(type: "int", nullable: false),
                    DepartIdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_instructors_departments_DepartIdId",
                        column: x => x.DepartIdId,
                        principalTable: "departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FNAme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LNAme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DepartIDId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_students_departments_DepartIDId",
                        column: x => x.DepartIDId,
                        principalTable: "departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseIns",
                columns: table => new
                {
                    InsID = table.Column<int>(type: "int", nullable: false),
                    courseID = table.Column<int>(type: "int", nullable: false),
                    Evaluate = table.Column<int>(type: "int", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseIns", x => new { x.courseID, x.InsID });
                    table.ForeignKey(
                        name: "FK_CourseIns_courses_courseID",
                        column: x => x.courseID,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseIns_instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "instructors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudCourse",
                columns: table => new
                {
                    StuID = table.Column<int>(type: "int", nullable: false),
                    courseID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudCourse", x => new { x.courseID, x.StuID });
                    table.ForeignKey(
                        name: "FK_StudCourse_courses_courseID",
                        column: x => x.courseID,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudCourse_students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "students",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseIns_InstructorId",
                table: "CourseIns",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_DepartIdId",
                table: "instructors",
                column: "DepartIdId");

            migrationBuilder.CreateIndex(
                name: "IX_StudCourse_StudentID",
                table: "StudCourse",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_students_DepartIDId",
                table: "students",
                column: "DepartIDId");

            migrationBuilder.CreateIndex(
                name: "IX_topic_CourseIDId",
                table: "topic",
                column: "CourseIDId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseIns");

            migrationBuilder.DropTable(
                name: "StudCourse");

            migrationBuilder.DropTable(
                name: "topic");

            migrationBuilder.DropTable(
                name: "instructors");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
