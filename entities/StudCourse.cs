using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.entities
{

    //[Table("StudCourse", Schema = "dbo")]

    internal class StudCourse
    {
        #region by comvention
        public int Grade { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        #endregion

        //#region by data annotations
        //public int Grade { get; set; }

        //[Key, Column(Order = 0)]

        //public Student StuID { get; set; }

        //[Key, Column(Order = 1)]

        //public Course CourseID { get; set; }

        //#endregion


    }
}
