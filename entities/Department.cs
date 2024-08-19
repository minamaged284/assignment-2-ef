using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.entities
{
    //[Table("Department", Schema = "dbo")]

    internal class Department
    {
        //    #region by comvention
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public DateTime HiringDate { get; set; }


        //    public ICollection<Student> StudentID { get; set; } = new List<Student>();
        //    public ICollection<Instructor> InstructorID { get; set; } = new List<Instructor>();
        //    #endregion

        //#region by data annotaions

        //[Key]
        //public int Id { get; set; }

        //[Required]
        //public string Name { get; set; }
        //[Required]
        //public DateTime HiringDate { get; set; }

        //[ForeignKey("DeptID")]
        //public ICollection<Student> StudentID { get; set; } = new List<Student>();



        //[ForeignKey("DepartmentID")]
        //public ICollection<Instructor> InstructorID { get; set; } = new List<Instructor>();
        //#endregion
        #region by fluentapis
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }


        public ICollection<Student>? StudtID { get; set; } = new List<Student>();
        public ICollection<Instructor>? InstID { get; set; } = new List<Instructor>();
        #endregion


    }
}
