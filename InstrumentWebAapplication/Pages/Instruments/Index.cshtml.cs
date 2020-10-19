using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InstrumentWebAapplication.Data;
using InstrumentWebAapplication.Models;

namespace InstrumentWebAapplication.Pages.Instruments
{
    public class IndexModel : PageModel
    {
        private readonly InstrumentWebAapplication.Data.InstrumentWebAapplicationContext _context;

        public IndexModel(InstrumentWebAapplication.Data.InstrumentWebAapplicationContext context)
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string PriceSort { get; set; }
        public string TypeSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        
        public IList<Instrument> Instrument { get;set; }
        public IList<AcousticGuitar> AcousticGuitar { get; set; }
        public IList<ElectricGuitar> ElectricGuitar { get; set; }
        public IList<AcousticPiano> AcousticPiano { get; set; }
        public IList<DigitalPiano> DigitalPiano { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            PriceSort = sortOrder == "Price" ? "price_desc" : "Price";
            TypeSort = sortOrder == "Type" ? "type_desc" : "Type";

            IQueryable<Instrument> instrumentsIQ = _context.Instrument.Select(instrument => instrument);

            switch (sortOrder)
            {
                case "name_desc":
                    instrumentsIQ = instrumentsIQ.OrderByDescending(s => s.Name);
                    break;
                case "Price":
                    instrumentsIQ = instrumentsIQ.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    instrumentsIQ = instrumentsIQ.OrderByDescending(s => s.Price);
                    break;
                default:
                    instrumentsIQ = instrumentsIQ.OrderBy(s => s.Name);
                    break;
            }
            Instrument = await instrumentsIQ.AsNoTracking().ToListAsync();
        }
    }
}
