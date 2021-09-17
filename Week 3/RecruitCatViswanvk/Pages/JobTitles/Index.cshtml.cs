using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatViswanvk.Data;
using RecruitCatViswanvk.Modules;

namespace RecruitCatViswanvk.Pages.JobTitles
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatViswanvk.Data.RecruitCatViswanvkContext _context;

        public IndexModel(RecruitCatViswanvk.Data.RecruitCatViswanvkContext context)
        {
            _context = context;
        }

        public IList<JobTitle> JobTitle { get;set; }

        public async Task OnGetAsync()
        {
            JobTitle = await _context.JobTitle.ToListAsync();
        }
    }
}
