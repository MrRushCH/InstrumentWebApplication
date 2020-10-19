using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace InstrumentWebAapplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly InstrumentWebAapplication.Data.InstrumentWebAapplicationContext _context;
        public IndexModel(ILogger<IndexModel> logger, InstrumentWebAapplication.Data.InstrumentWebAapplicationContext context)
        {
            _logger = logger;
            _context = context;
        }


        public int TotalInstruments { get; set; }
        public int TotalAcousticGuitars { get; set; }
        public int TotalElectricGuitars { get; set; }
        public int TotalAcousticPianos { get; set; }
        public int TotalDigitalPianos { get; set; }

        public void OnGet()
        {
            TotalInstruments = _context.Instrument.Count();
            TotalAcousticGuitars = _context.AcousticGuitar.Count();
            TotalElectricGuitars = _context.ElectricGuitar.Count();
            TotalAcousticPianos = _context.AcousticPiano.Count();
            TotalDigitalPianos = _context.DigitalPiano.Count();
        }
    }
}
