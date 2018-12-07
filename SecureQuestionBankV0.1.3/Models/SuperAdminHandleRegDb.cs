using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SecureQuestionBankV0._1._3.Models
{
    public class SuperAdminHandleRegDb
    {
        public SqlConnection con;
        public void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["DbService"].ToString();
            con = new SqlConnection(constring);
        }

        public bool AddSuperAdmin(SuperAdmin supa)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AddSuperAminRegP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", supa.Name);
            cmd.Parameters.AddWithValue("@Email", supa.EmailId);
            cmd.Parameters.AddWithValue("@Password", supa.Password);
            cmd.Parameters.AddWithValue("@Mobile", supa.MobileNumber);
            cmd.Parameters.AddWithValue("@Address", supa.Address);
            cmd.Parameters.AddWithValue("@GovtVerifiedCode", supa.GovtVerifiedCode);
            cmd.Parameters.AddWithValue("@AdminCode", supa.AdminCode);
            cmd.Parameters.AddWithValue("@CentreCode", supa.CentreAdmin);
            cmd.Parameters.AddWithValue("@Examcategory", supa.ExamCategory);

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