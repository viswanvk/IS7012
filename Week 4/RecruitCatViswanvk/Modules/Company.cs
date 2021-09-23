using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatViswanvk.Modules
{
    public class Company
    {
        [DisplayName("Company ID")]
        public int CompanyId { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is 50 characters")]
        [Required(ErrorMessage = "Company name is required")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is 50 characters")]
        [Required(ErrorMessage = "Position name is required")]
        [DisplayName("Position Name")]
        public string PositionName { get; set; }

        [Range(0, 10000000000)]
        [DisplayName("Minimum Salary")]
        public decimal MinimumSalary { get; set; }

        [Range(0, 10000000000)]
        [DisplayName("Maximum Salary")]
        public decimal MaximumSalary { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }

        [StringLength(500, ErrorMessage = "Maximum length is 500 characters")]
        public string Location { get; set; }

        [DisplayName("Currently Recruiting")]
        public bool? CurrentlyRecruiting { get; set; }

        public List<Candidate> Candidates { get; set; }

        public Industry Industry { get; set; }

        [DisplayName("Industry")]
        public int IndustryId { get; set; }
    }
}
