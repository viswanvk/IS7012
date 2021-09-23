using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatViswanvk.Modules
{
    public class Candidate
    {
        [StringLength(50, ErrorMessage = "Maximum length is 50 characters")]
        [Required(ErrorMessage ="First name is required")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Candidate ID")]
        public int CandidateId { get; set; }

        [StringLength(50,ErrorMessage ="Maximum length is 50 characters")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Range(0,10000000000)]
        [DisplayName("Target Salary")]
        public decimal TargetSalary { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is 50 characters")]
        [DisplayName("Current Location")]
        public string CurrentLocation { get; set; }

        [DisplayName("Years of Experience")]
        public int YearsOfExperience { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        public Company? Company { get; set; }

        [DisplayName("Company")]
        public int CompanyId { get; set; }

        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }

        [DisplayName("Job Title")]
        public int JobTitleId { get; set; }

        public Industry Industry { get; set; }

        [DisplayName("Industry")]
        public int IndustryId { get; set; }
    }
}
