using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatViswanvk.Modules
{
    public class Candidate
    {
        public string FirstName { get; set; }
        public int CandidateId { get; set; }
        public string LastName { get; set; }
        public decimal TargetSalary { get; set; }
        public DateTime StartDate { get; set; }
        public string CurrentLocation { get; set; }
        public int YearsOfExperience { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Company? Company { get; set; }
        public int CompanyId { get; set; }
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
    }
}
