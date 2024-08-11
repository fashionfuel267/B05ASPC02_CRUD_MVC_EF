using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace B05ASPC02_w01.Models
{
    //SOLID
    //ORM-EF
    //ADO
    //convention
    public class Student
    {
        //pk,Identity
        public int Id { get; set; }
        [StringLength(15)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Description { get; set; }


    }
}