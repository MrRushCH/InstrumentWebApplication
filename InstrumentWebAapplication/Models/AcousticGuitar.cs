using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace InstrumentWebAapplication.Models
{
    public class AcousticGuitar : Guitar
    {
        [Range(0, 20)]
        public int CapoPosition { get; set; }
    }
}
