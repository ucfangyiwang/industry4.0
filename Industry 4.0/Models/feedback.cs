using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Industry_4._0.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Topic Title")]
        public string Heading { get; set; }

        [Display(Name = "StarRating")]
        [Range(0, 5)]
        public int StarRating { get; set; }

      
        [Display(Name = "Feedback")]
        public string FEEdback { get; set; }

        public int Agree { get; set; }
        public int Disagree { get; set; }
        public string CompanyOrganisationName { get; set; }
        public bool IncreaseAgree { get; set; }
        public bool IncreaseDisagree { get; set; }
    }
}
