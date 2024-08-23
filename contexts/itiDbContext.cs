using assignment_1.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.contexts
{
    internal class itiDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = ITIDb ; Trusted_Connection = True ; Encrypt= False");
        }
        //#region by convention 
        //DbSet<Student> students { get; set; }
        //DbSet<Instructor> instructors { get; set; }
        //DbSet<Department> departments { get; set; }
        //DbSet<Course> courses { get; set; }
        //DbSet<Topic> topic { get; set; }
        //DbSet<CourseIns> coursesIns { get; set; }
        //DbSet<StudCourse> studCourse { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<CourseIns>(e => e.HasNoKey());
        //    modelBuilder.Entity<StudCourse>(e => e.HasNoKey());

        //}

        //#endregion


        #region by fluent apis 
        DbSet<Student> students { get; set; }
        DbSet<Instructor> instructors { get; set; }
        DbSet<Department> departments { get; set; }
        DbSet<Course> courses { get; set; }
        DbSet<Topic> topic { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        




            modelBuilder.Entity<Course>().HasKey(nameof(Course.Id));
            modelBuilder.Entity<Course>().HasMany(c => c.TopID).WithOne(t => t.CourseID);
            modelBuilder.Entity<Course>().HasMany(c => c.StudCourse).WithOne();
            modelBuilder.Entity<Course>().HasMany(c => c.CourseIns).WithOne();




            modelBuilder.Entity<Department>().HasKey(nameof(Department.Id));
            modelBuilder.Entity<Department>().HasMany(d => d.StudtID).WithOne(s => s.DepartID);
            modelBuilder.Entity<Department>().HasMany(d => d.InstID).WithOne(s => s.DepartId);

            modelBuilder.Entity<Instructor>().HasKey(nameof(Instructor.Id));
            modelBuilder.Entity<Instructor>().HasMany(i => i.CourseInstructor).WithOne();


            modelBuilder.Entity<Student>().HasKey(nameof(Student.ID));
            modelBuilder.Entity<Student>().HasMany(s => s.StudentCourse).WithOne();


            modelBuilder.Entity<Topic>().HasKey(nameof(Topic.Id));

            modelBuilder.Entity<CourseIns>().HasKey(ci => new { ci.CourseID, ci.InstructorID });
            modelBuilder.Entity<StudCourse>().HasKey(sc => new { sc.StudentID, sc.CourseID });






        }

        #endregion









    }
}
