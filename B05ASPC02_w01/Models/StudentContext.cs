using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace B05ASPC02_w01.Models
{
    public class StudentContext:DbContext
    {
        
        public DbSet<Student> Students { get; set; }
    }
}