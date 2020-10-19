using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InstrumentWebAapplication.Data;
using InstrumentWebAapplication.Models;

namespace InstrumentWebAapplication.Pages.AcousticPianos
{
    public class EditModel : PageModel
    {
        private readonly InstrumentWebAapplication.Data.InstrumentWebAapplicationContext _context;

        public EditModel(InstrumentWebAapplication.Data.InstrumentWebAapplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AcousticPiano).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AcousticPianoExists(AcousticPiano.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AcousticPianoExists(int id)
        {
            return _context.AcousticPiano.Any(e => e.Id == id);
        }
    }
}
