using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class dataannotations4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Department",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HiringDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "dbo",
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
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HourRate = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructor_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalSchema: "dbo",
                        principalTable: "Department",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Student",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FNAme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LNAme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DeptID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Student_Department_DeptID",
                        column: x => x.DeptID,
                        principalSchema: "dbo",
                        principalTable: "Department",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topic_Employees_CourseID",
                        column: x => x.CourseID,
                        principalSchema: "dbo",
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CourseIns",
                schema: "dbo",
                columns: table => new
                {
                    Evaluate = table.Column<int>(type: "int", nullable: false),
                    InsIDId = table.Column<int>(type: "int", nullable: false),
                    COurseIDId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CourseIns_Employees_COurseIDId",
                        column: x => x.COurseIDId,
                        principalSchema: "dbo",
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseIns_Instructor_InsIDId",
                        column: x => x.InsIDId,
                        principalSchema: "dbo",
                        principalTable: "Instructor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudCourse",
                schema: "dbo",
                columns: table => new
                {
                    Grade = table.Column<int>(type: "int", nullable: false),
                    StuIDID = table.Column<int>(type: "int", nullable: false),
                    CourseIDId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_StudCourse_Employees_CourseIDId",
                        column: x => x.CourseIDId,
                        principalSchema: "dbo",
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudCourse_Student_StuIDID",
                        column: x => x.StuIDID,
                        principalSchema: "dbo",
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseIns_COurseIDId",
                schema: "dbo",
                table: "CourseIns",
                column: "COurseIDId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseIns_InsIDId",
                schema: "dbo",
                table: "CourseIns",
                column: "InsIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_DepartmentID",
                schema: "dbo",
                table: "Instructor",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_StudCourse_CourseIDId",
                schema: "dbo",
                table: "StudCourse",
                column: "CourseIDId");

            migrationBuilder.CreateIndex(
                name: "IX_StudCourse_StuIDID",
                schema: "dbo",
                table: "StudCourse",
                column: "StuIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_DeptID",
                schema: "dbo",
                table: "Student",
                column: "DeptID");

            migrationBuilder.CreateIndex(
                name: "IX_Topic_CourseID",
                schema: "dbo",
                table: "Topic",
                column: "CourseID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseIns",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StudCourse",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Topic",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Instructor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Student",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Department",
                schema: "dbo");
        }
    }
}
