using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace u24687473_INF272_Practical_2.Models
{
    public class Students
    {
        [Key]
        [Display(Name = "Student Number")]
        public string StudentID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string StudentEmail { get; set; }

        [Required]
        [Display(Name = "Profile Link")]
        public string myLink { get; set; }
    }
}
