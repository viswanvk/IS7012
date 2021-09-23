using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatViswanvk.Modules
{
    public class Industry
    {
        [DisplayName("Industry ID")]
        public int IndustryId { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is 50 characters")]
        [Required(ErrorMessage = "Industry name is required")]
        public string Name { get; set; }

        public List<Candidate> Candidates { get; set; }

        public List<Company> Companies { get; set; }
    }
}
