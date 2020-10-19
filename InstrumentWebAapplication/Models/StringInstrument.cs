using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace InstrumentWebAapplication.Models
{
    public abstract class StringInstrument : Instrument
    {
        public int NumberOfStrings { get; set; }
    }
}
