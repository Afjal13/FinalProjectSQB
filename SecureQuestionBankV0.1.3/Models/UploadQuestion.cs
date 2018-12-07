
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;


namespace SecureQuestionBankV0._1._3.Models
{
    public class UploadQuestion
    {
        DataManage dam = new DataManage();
        public int Id { get; set; }

        [Required(ErrorMessage = "Title required")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "File name")]
        public string FileName { get; set; }

        [Display(Name = "Uploaded file")]
        public string FilePath { get; set; }

        public HttpPostedFileBase Files { get; set; }

        [Required(ErrorMessage = "Date required")]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        public List<UploadQuestion> Data { get; set; }


        public bool publishNotice()
        {
            string query = @"INSERT INTO QuestionPdfTable (Title, FileName, FilePath, Date) VALUES ('" + Title + "', '" + FileName + "', '" + FilePath + "', '" + Date + "')";

            int i = dam.Execute(query);

            if (i >= 1)
                return true;
            else
                return false;
        }

        public List<UploadQuestion> viewNotices()
        {
            List<UploadQuestion> noticelist = new List<UploadQuestion>();
            string query = @"SELECT* FROM QuestionPdfTable ";

            foreach (DataRow dr in dam.GetDataTable(query).Rows)
            {
                noticelist.Add(new UploadQuestion
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Title = Convert.ToString(dr["Title"]),
                    FileName = Convert.ToString(dr["FileName"]),
                    FilePath = Convert.ToString(dr["FilePath"]),
                    Date = Convert.ToDateTime(dr["Date"]),
                });
            }
            return noticelist;
        }

        public void GetFiles(int id)
        {
            string query = @"SELECT* FROM QuestionPdfTable WHERE Id = " + Id + "";

            foreach (DataRow dr in dam.GetDataTable(query).Rows)
            {
                FileName = Convert.ToString(dr["FileName"]);
                FilePath = Convert.ToString(dr["FilePath"]);
            }
        }

        public bool deleteFile(int id)
        {
            string query = @"DELETE FROM QuestionPdfTable WHERE Id = " + id + "";

            int i = dam.Execute(query);

            if (i >= 1)
                return true;
            else
                return false;
        }

    }
}