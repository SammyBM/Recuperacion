using System;

namespace Recuperacion.Models
{
    public class Conference
    {
        [key]
        public int ConferenceID { get; set; }
        public string Name { get; set; }
        public Person Presenter { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public decimal? Cost {get; set; }
        public int Capacity {get; set; }
    }
