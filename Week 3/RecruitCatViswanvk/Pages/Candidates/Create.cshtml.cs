﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatViswanvk.Data;
using RecruitCatViswanvk.Modules;

namespace RecruitCatViswanvk.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatViswanvk.Data.RecruitCatViswanvkContext _context;

        public CreateModel(RecruitCatViswanvk.Data.RecruitCatViswanvkContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "CompanyId", "CompanyId");
        ViewData["IndustryId"] = new SelectList(_context.Set<Industry>(), "IndustryId", "IndustryId");
        ViewData["JobTitleId"] = new SelectList(_context.Set<JobTitle>(), "JobTitleId", "JobTitleId");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
