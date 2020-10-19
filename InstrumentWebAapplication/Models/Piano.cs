using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentWebAapplication.Models
{
    public abstract class Piano : KeyboardInstrument
    {
        public bool HasPedal { get; set; }
    }
}
