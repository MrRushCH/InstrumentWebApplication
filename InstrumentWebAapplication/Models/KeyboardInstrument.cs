using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentWebAapplication.Models
{
    public abstract class KeyboardInstrument : Instrument
    {
        public int NumberOfKeys { get; set; }
    }
}
