using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.entities
{

    //[Table("Student", Schema = "dbo")]

    internal class Student
    {
        //#region by comvention
        //public int ID { get; set; }
        //public string FNAme { get; set; }
        //public string LNAme { get; set; }
        //public string Adress { get; set; }
        //public int Age { get; set; }

        //public Department DepartmentID { get; set; }
        //#endregion

        //#region by data annotaions

        //[Key]
        //public int ID { get; set; }
        //public string FNAme { get; set; }
        //public string LNAme { get; set; }
        //public string Adress { get; set; }
        //public int Age { get; set; }

        //#endregion


        #region by fluent apis
        public int ID { get; set; }
        public string FNAme { get; set; }
        public string LNAme { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }

        public Department DepartID { get; set; }
        #endregion





    }
}
