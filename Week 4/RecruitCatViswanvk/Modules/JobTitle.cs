using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatViswanvk.Modules
{
    public class JobTitle
    {
        [DisplayName("Job Title ID")]
        public int JobTitleId { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is 50 characters")]
        [Required(ErrorMessage = "Job Title is required")]
        public string Title { get; set; }

        [Range(0, 10000000000)]
        [DisplayName("Minimum Salary")]
        public decimal MinimumSalary { get; set; }

        [Range(0, 10000000000)]
        [DisplayName("Maximum Salary")]
        public decimal MaximumSalary { get; set; }

        [StringLength(500, ErrorMessage = "Maximum length is 500 characters")]
        public string Responsibilities { get; set; }

        [DisplayName("Average Salary")]
        public decimal? AverageSalary { get; set; }

        public List<Candidate> Candidates { get; set; }
    }
}
