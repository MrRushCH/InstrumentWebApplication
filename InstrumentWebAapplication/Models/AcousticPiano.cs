using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace InstrumentWebAapplication.Models
{
    public class AcousticPiano : Piano
    {
        [Range(0, 10)]
        public int InTuneLevel { get; set; }
        protected bool HoodOpen;
    }
}
