using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InstrumentWebAapplication.Data;
using InstrumentWebAapplication.Models;

namespace InstrumentWebAapplication.Pages.AcousticPianos
{
    public class DetailsModel : PageModel
    {
        private readonly InstrumentWebAapplication.Data.InstrumentWebAapplicationContext _context;

        public DetailsModel(InstrumentWebAapplication.Data.InstrumentWebAapplicationContext context)
        {
            _context = context;
        }

        public AcousticPiano AcousticPiano { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AcousticPiano = await _context.AcousticPiano.FirstOrDefaultAsync(m => m.Id == id);

            if (AcousticPiano == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
