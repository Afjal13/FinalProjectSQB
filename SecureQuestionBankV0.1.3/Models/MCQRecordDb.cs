using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SecureQuestionBankV0._1._3.Models
{
    public class MCQRecordDb
    {
        public SqlConnection con;
        public void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["DbService"].ToString();
            con = new SqlConnection(constring);
        }

        public bool AddMCQRecord(MCQRecord mCQRecord)
        {
            connection();
            SqlCommand cmd = new SqlCommand("MCQQRP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SubjectName", mCQRecord.Name);
            cmd.Parameters.AddWithValue("@SubjectCode", mCQRecord.SubjectCode);
            cmd.Parameters.AddWithValue("@MCQQcode", mCQRecord.QuestionCode);
            cmd.Parameters.AddWithValue("@Year", mCQRecord.YaerType);
            cmd.Parameters.AddWithValue("@QuestionType", mCQRecord.GetQuestionType);
            cmd.Parameters.AddWithValue("@OptionQuantity", mCQRecord.OptionNumber);
            cmd.Parameters.AddWithValue("@Setquantity", mCQRecord.RequireSetNumber);
            cmd.Parameters.AddWithValue("@QuestionQuantity", mCQRecord.QuestionQuantity);
            cmd.Parameters.AddWithValue("@SetTime", mCQRecord.SetTime);
            cmd.Parameters.AddWithValue("@SetType", mCQRecord.RequireSetType);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}