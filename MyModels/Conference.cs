using System;

namespace Recuperacion.MyModels
{
    public class Conference
    {
        [key]
        public int ConferenceID { get; set; }
        public string Name { get; set; }
        public int Presenter { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public decimal? Cost {get; set; }
        public int Capacity {get; set; }
    }
