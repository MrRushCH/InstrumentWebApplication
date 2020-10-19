using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace InstrumentWebAapplication.Models
{
    public class ElectricGuitar : Guitar
    {
        [Range(0, 10)]
        public int VolumeSetting { get; set; }
    }
}
