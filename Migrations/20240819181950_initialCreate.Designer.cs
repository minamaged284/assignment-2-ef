﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using assignment_1.contexts;

#nullable disable

namespace assignment_1.Migrations
{
    [DbContext(typeof(itiDbContext))]
    [Migration("20240819181950_initialCreate")]
    partial class initialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("assignment_1.entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("assignment_1.entities.CourseIns", b =>
                {
                    b.Property<int>("COurseIDId")
                        .HasColumnType("int");

                    b.Property<int>("Evaluate")
                        .HasColumnType("int");

                    b.Property<int>("InsIDId")
                        .HasColumnType("int");

                    b.HasIndex("COurseIDId");

                    b.HasIndex("InsIDId");

                    b.ToTable("coursesIns");
                });

            modelBuilder.Entity("assignment_1.entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("assignment_1.entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Bonus")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DepartmenttIDId")
                        .HasColumnType("int");

                    b.Property<int>("HourRate")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmenttIDId");

                    b.ToTable("instructors");
                });

            modelBuilder.Entity("assignment_1.entities.StudCourse", b =>
                {
                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StuIDID")
                        .HasColumnType("int");

                    b.HasIndex("StuIDID");

                    b.ToTable("studCourse");
                });

            modelBuilder.Entity("assignment_1.entities.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentIDId")
                        .HasColumnType("int");

                    b.Property<string>("FNAme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LNAme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentIDId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("assignment_1.entities.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("topic");
                });

            modelBuilder.Entity("assignment_1.entities.CourseIns", b =>
                {
                    b.HasOne("assignment_1.entities.Course", "COurseID")
                        .WithMany()
                        .HasForeignKey("COurseIDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("assignment_1.entities.Instructor", "InsID")
                        .WithMany()
                        .HasForeignKey("InsIDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("COurseID");

                    b.Navigation("InsID");
                });

            modelBuilder.Entity("assignment_1.entities.Instructor", b =>
                {
                    b.HasOne("assignment_1.entities.Department", "DepartmenttID")
                        .WithMany("InstructorID")
                        .HasForeignKey("DepartmenttIDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DepartmenttID");
                });

            modelBuilder.Entity("assignment_1.entities.StudCourse", b =>
                {
                    b.HasOne("assignment_1.entities.Student", "StuID")
                        .WithMany()
                        .HasForeignKey("StuIDID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StuID");
                });

            modelBuilder.Entity("assignment_1.entities.Student", b =>
                {
                    b.HasOne("assignment_1.entities.Department", "DepartmentID")
                        .WithMany("StudentID")
                        .HasForeignKey("DepartmentIDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DepartmentID");
                });

            modelBuilder.Entity("assignment_1.entities.Topic", b =>
                {
                    b.HasOne("assignment_1.entities.Course", null)
                        .WithMany("TopicID")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("assignment_1.entities.Course", b =>
                {
                    b.Navigation("TopicID");
                });

            modelBuilder.Entity("assignment_1.entities.Department", b =>
                {
                    b.Navigation("InstructorID");

                    b.Navigation("StudentID");
                });
#pragma warning restore 612, 618
        }
    }
}
