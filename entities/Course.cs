using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.entities
{
    //[Table("Course", Schema ="dbo")]
    internal class Course
    {

        //#region by convention
        //public int Id { get; set; }
        //public int Duration { get; set; }
        //public string Name { get; set; }
        //public string Description { get; set; }
        //public ICollection<Topic> TopicID { get; set; } = new List<Topic>();

        //#endregion

        //#region by data annotations

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        //public int Duration { get; set; }
        //public string Name { get; set; }
        //public string Description { get; set; }

        //[ForeignKey("CourseID")]
        //public ICollection<Topic> TopicID { get; set; } = new List<Topic>();

        //#endregion


        #region by fluent apis
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Topic> TopID { get; set; } = new List<Topic>();

        #endregion


    }
}
