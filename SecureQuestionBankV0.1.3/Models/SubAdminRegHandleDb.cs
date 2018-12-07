using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SecureQuestionBankV0._1._3.Models
{
    public class SubAdminRegHandleDb
    {
        public SqlConnection con;
        public void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["DbService"].ToString();
            con = new SqlConnection(constring);
        }

        public bool AddSubAdmin(SubAdmin Sua)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AddAminRegP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", Sua.Name);
            cmd.Parameters.AddWithValue("@Email", Sua.EmailId);
            cmd.Parameters.AddWithValue("@Password", Sua.Password);
            cmd.Parameters.AddWithValue("@Mobile", Sua.MobileNumber);
            cmd.Parameters.AddWithValue("@Address", Sua.Address);
            cmd.Parameters.AddWithValue("@Organization", Sua.OrganizationName);
            cmd.Parameters.AddWithValue("@Admincode", Sua.AdminCode);
            cmd.Parameters.AddWithValue("@Personalcode", Sua.PersonalCode);
            cmd.Parameters.AddWithValue("@Examcategory", Sua.ExamCategory);

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