using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.entities
{

    //[Table("Topic", Schema = "dbo")]

    internal class Topic
    {

        //#region by comvention
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public Course CourseID { get; set; }
        //#endregion


        //#region by comvention

        //[Key]
        //public int Id { get; set; }
        //public string Name { get; set; }
        //#endregion


        #region by fluent aois
        public int Id { get; set; }
        public string Name { get; set; }
        public Course? CourseID { get; set; }
        #endregion


    }
}
