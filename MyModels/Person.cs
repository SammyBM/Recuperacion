using System;

namespace Recuperacion.MyModels
{
    public class Person
    {
        [key]
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string LastName {get; set; }
        public string Email {get; set; }
        public string Password {get; set;}
}
