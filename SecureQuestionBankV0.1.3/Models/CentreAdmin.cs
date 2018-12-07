using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SecureQuestionBankV0._1._3.Models
{
    public class CentreAdmin
    {
        [Display(Name = "Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name required")]
        public string Name { get; set; }
        [Display(Name = "Email ID")]
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
        [Required(AllowEmptyStrings = false, ErrorMessage = "Organization name  required")]
        public string OrganizationName { get; set; }
        [Display(Name = "EMIS Code")]
        [Required(AllowEmptyStrings = false, ErrorMessage = " EMIS Code  required")]
        public string EmisCode { get; set; }
        [Display(Name = "Exam Type")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Exam Type  required")]
        public string ExamType { get; set; }
        [Display(Name = "Super Admin Code")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Super Admin Code required")]
        public string SuperAdminCode { get; set; }

    }
}