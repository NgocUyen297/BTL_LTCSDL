using System;
using System.Collections.Generic;

#nullable disable

namespace CuaHangVatTu.DAL.Models
{
    public partial class Tonkho
    {
        public int Namthang { get; set; }
        public int Mavtu { get; set; }
        public int? Sldau { get; set; }
        public int? Tongsln { get; set; }
        public int? Tongslx { get; set; }
        public int? Slcuoi { get; set; }

        public virtual Vattu MavtuNavigation { get; set; }
    }
}
