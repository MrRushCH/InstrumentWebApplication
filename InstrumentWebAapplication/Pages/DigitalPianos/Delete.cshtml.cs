using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InstrumentWebAapplication.Data;
using InstrumentWebAapplication.Models;

namespace InstrumentWebAapplication.Pages.DigitalPianos
{
    public class DeleteModel : PageModel
    {
        private readonly InstrumentWebAapplication.Data.InstrumentWebAapplicationContext _context;

        public DeleteModel(InstrumentWebAapplication.Data.InstrumentWebAapplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DigitalPiano DigitalPiano { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DigitalPiano = await _context.DigitalPiano.FirstOrDefaultAsync(m => m.Id == id);

            if (DigitalPiano == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DigitalPiano = await _context.DigitalPiano.FindAsync(id);

            if (DigitalPiano != null)
            {
                _context.DigitalPiano.Remove(DigitalPiano);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
