using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatViswanvk.Modules
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string PositionName { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public string Location { get; set; }
        public bool? CurrentlyRecruiting { get; set; }
        public List<Candidate> Candidates { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
    }
}
