using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SecureQuestionBankV0._1._3.Models
{
    public class MCQRecord
    {
        [Display(Name = "Subject Name:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Subject name required")]
        public string Name { get; set; }
        [Display(Name = "Subject Code:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Subject code required")]
        public string SubjectCode { get; set; }
        [Display(Name = "Enter question Code:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Question code required")]
        public string QuestionCode { get; set; }
        [Display(Name = "Select Year:")]
        public YearsList YaerType { get; set; }
        [Display(Name = "Question Type:")]
        public QuestionType GetQuestionType { get; set; }
        [Display(Name = "Option quantity:")]
        public OptionList OptionNumber { get; set; }
        [Display(Name = "Set quantity:")]
        public SetNumberList RequireSetNumber { get; set; }
        [Display(Name = "Set type:")]
        public SetTypeList RequireSetType { get; set; }
        [Display(Name = "Question quantity:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Question quantity required")]
        public string QuestionQuantity { get; set; }
        [Display(Name = "Set time(in minite):")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Set time required")]
        public int SetTime { get; set; }

    }

    public enum YearsList
    {
        [Display(Name = "Select")]
        select,
        [Display(Name = "2018")]
        Eighteen,
        [Display(Name = "2019")]
        Nineteen,
        [Display(Name = "2020")]
        Tweenty,
        [Display(Name = "2021")]
        TweentyOne,
        [Display(Name = "2022")]
        TweentyTwo
    }

    public enum QuestionType
    {
        [Display(Name = "Select")]
        s,
        [Display(Name = "BCS")]
        bcs,
        [Display(Name = "HSC")]
        hsc,
        [Display(Name = "SSC")]
        ssc,
        [Display(Name = "JSC")]
        jsc,
        [Display(Name = "PSC")]
        psc
    }

    public enum OptionList
    {
        [Display(Name = "Select")]
        select,
        [Display(Name = "5")]
        five,
        [Display(Name = "4")]
        four,
        [Display(Name = "3")]
        three,
        [Display(Name = "2")]
        two

    }

    public enum SetNumberList
    {
        [Display(Name = "Select")]
        select,
        [Display(Name = "1")]
        One,
        [Display(Name = "2")]
        Two,
        [Display(Name = "3")]
        Three,
        [Display(Name = "4")]
        Four,
        [Display(Name = "5")]
        Five,
        [Display(Name = "6")]
        Six,
        [Display(Name = "7")]
        Seven,
        [Display(Name = "8")]
        Eignt,
        [Display(Name = "9")]
        Nine,
        [Display(Name = "10")]
        Ten
    }

    public enum SetTypeList
    {
        [Display(Name = "Select")]
        select,
        [Display(Name = "Capital Letter")]
        capitalLetter,
        [Display(Name = "Small Letter")]
        smallLetter,
        [Display(Name = "Numerical")]
        numericalLetter,
        [Display(Name = "Roman")]
        romanLetter

    }
}