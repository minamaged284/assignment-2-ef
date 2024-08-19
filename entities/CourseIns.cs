using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.entities
{
    //[Table("CourseIns", Schema = "dbo")]

    internal class CourseIns
    {
        #region by comvention
        public int Evaluate { get; set; }

        public Instructor InsID { get; set; }
        public Course COurseID { get; set; }
        #endregion

        //#region by data annotaions
        //public int Evaluate { get; set; }

        //[Key,Column(Order =1)]
        //public Instructor InsID { get; set; }

        //[Key, Column(Order = 0)]

        //public Course COurseID { get; set; }
        //#endregion



    }
}
