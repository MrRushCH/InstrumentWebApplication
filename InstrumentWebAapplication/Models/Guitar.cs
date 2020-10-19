using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace InstrumentWebAapplication.Models
{
    public abstract class Guitar : StringInstrument
    {
        public int NumberOfFrets { get; set; }
        [Range(0, 10)]
        public int InTuneLevel { get; set; } = 10;
    }
}
