using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SecureQuestionBankV0._1._3.Models
{
    public class QuestionUpdate
    {
        [Display(Name = "Subject Code:")]
        public SubjectCodelist SubjectCode { get; set; }
        [Display(Name = " Year:")]
        public YearList Year { get; set; }
        [Display(Name = "Category:")]
        public CategoryList Category { get; set; }
    }
    public enum SubjectCodelist
    {
        [Display(Name = "Select")]
        s,
        [Display(Name = "BCS123")]
        bcs123,
        [Display(Name = "HSC234")]
        hsc234,
        [Display(Name = "SSC345")]
        ssc345,
        [Display(Name = "JSC456")]
        jsc456,
        [Display(Name = "PSC567")]
        psc567
    }
    public enum YearList
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
    public enum CategoryList
    {
        [Display(Name = "Select")]
        s,
        [Display(Name = "MCQ")]
        mcq,
        [Display(Name = "CQ")]
        cq

    }
}