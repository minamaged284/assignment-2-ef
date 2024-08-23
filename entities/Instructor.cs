using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.entities
{
    //[Table("Instructor", Schema = "dbo")]

    internal class Instructor
    {
        //#region by comvention

        //public int Id { get; set; }
        //public string Name { get; set; }
        //public decimal Bonus { get; set; }
        //public decimal Salary { get; set; }
        //public string Address { get; set; }
        //public int HourRate { get; set; }
        //public Department DepartmentId { get; set; }


        //#endregion



        //#region by fata annotations
        //[Key]
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public decimal Bonus { get; set; }
        //public decimal Salary { get; set; }
        //public string Address { get; set; }
        //public int HourRate { get; set; }


        //#endregion

        #region by fluent apis

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Bonus { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }

        public ICollection<CourseIns> CourseInstructor { get; set; } = new HashSet<CourseIns>();
        public Department DepartId { get; set; }


        #endregion
    }
}
