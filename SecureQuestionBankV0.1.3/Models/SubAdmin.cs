using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace SecureQuestionBankV0._1._3.Models
{
    public class SubAdmin
    {
        [Display(Name ="Name")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Name required")]
        public string Name { get; set; }
        [Display(Name ="Email ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email id required")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password required")]
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm password required")]
        public string confirmPassword { get; set; }
        [Display(Name = "Mobile Number")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mobile number required")]
        public string MobileNumber { get; set; }
        [Display(Name = "Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Address required")]
        public string Address { get; set; }
        [Display(Name = "Organization name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Organization name required")]
        public string OrganizationName { get; set; }
        [Display(Name = "Admin code")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Admin code required")]
        public string AdminCode { get; set; }
        [Display(Name = "Create Personal code")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must have Personal code  required")]
        public string PersonalCode { get; set; }
        [Display(Name = "Exam Category")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Exam category required")]
        public string ExamCategory { get; set; }
    }
}