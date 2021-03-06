﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly InstrumentWebAapplication.Data.InstrumentWebAapplicationContext _context;

        public DeleteModel(InstrumentWebAapplication.Data.InstrumentWebAapplicationContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AcousticPiano = await _context.AcousticPiano.FindAsync(id);

            if (AcousticPiano != null)
            {
                _context.AcousticPiano.Remove(AcousticPiano);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
