using System;
using System.ComponentModel.DataAnnotations;

namespace Recuperacion.MyModels
{
    public class Atendees
    {
        [Key]
        public int AtendeesID {get; set; }
        public int PersonID { get; set; }
        public int ConferenceID {get; set; }
    }
}
