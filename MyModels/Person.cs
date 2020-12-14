using System;
using System.ComponentModel.DataAnnotations;

namespace Recuperacion.MyModels
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string LastName {get; set; }
        public string Email {get; set; }
        public string Password {get; set;}
    }
}
