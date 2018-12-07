using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SecureQuestionBankV0._1._3.Models
{
    public class LoginClass
    {
        [Required(ErrorMessage ="Please enter email id")]
        [Display(Name ="Email ID:")]
        public string emailId { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}