using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SecureQuestionBankV0._1._3.Models
{
    public class MCQQuestionUpdate
    {
        [Display(Name = "Question No:")]

        public string QuestionNo { get; set; }
        [Display(Name = "Enter Question Description:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Question Description  required")]
        public string QuestionDescription { get; set; }
        [Display(Name = "Option 1:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Option required")]
        public string option1 { get; set; }
        [Display(Name = "Option 2:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Option required")]
        public string option2 { get; set; }
        [Display(Name = "Option 3:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Option required")]
        public string option3 { get; set; }
        [Display(Name = "Option 4:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Option required")]
        public string option4 { get; set; }
        [Display(Name = "Corerrect Option:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Correct Option required")]
        public MCQUOptionList CorrectOption { get; set; }

    }
    public enum MCQUOptionList
    {
        [Display(Name = "Select")]
        select,
        [Display(Name = "OPtion 1")]
        Option1,
        [Display(Name = "OPtion 2")]
        Option2,
        [Display(Name = "OPtion 3")]
        Option3,
        [Display(Name = "OPtion 4")]
        Option4

    }
}