using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InstrumentWebAapplication.Data;
using InstrumentWebAapplication.Models;

namespace InstrumentWebAapplication.Pages.ElectricGuitars
{
    public class CreateModel : PageModel
    {
        private readonly InstrumentWebAapplication.Data.InstrumentWebAapplicationContext _context;

        public CreateModel(InstrumentWebAapplication.Data.InstrumentWebAapplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ElectricGuitar ElectricGuitar { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ElectricGuitar.Add(ElectricGuitar);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
