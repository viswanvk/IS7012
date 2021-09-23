using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatViswanvk.Modules;

namespace RecruitCatViswanvk.Data
{
    public class RecruitCatViswanvkContext : DbContext
    {
        public RecruitCatViswanvkContext (DbContextOptions<RecruitCatViswanvkContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatViswanvk.Modules.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatViswanvk.Modules.Company> Company { get; set; }

        public DbSet<RecruitCatViswanvk.Modules.Industry> Industry { get; set; }

        public DbSet<RecruitCatViswanvk.Modules.JobTitle> JobTitle { get; set; }
    }
}
