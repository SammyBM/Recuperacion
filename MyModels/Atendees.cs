using System;

namespace Recuperacion.MyModels
{
    public class Atendees
    {
        [key]
        public int AtendeesID {get; set; }
        public int PersonID { get; set; }
        public int ConferenceID {get; set; }
    }
