using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SurveySdssheets
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string Manufacturer { get; set; }
        public string TradeName { get; set; }
        public bool Deleted { get; set; }
        public int? Fid { get; set; }
    }
}
