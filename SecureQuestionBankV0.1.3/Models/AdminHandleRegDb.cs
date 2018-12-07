using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SecureQuestionBankV0._1._3.Models
{
    public class AdminHandleRegDb
    {
        public SqlConnection con;
        public void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["DbService"].ToString();
            con = new SqlConnection(constring);
        }

        public bool AddAdmin(Admin Ad)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AddAdRegP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", Ad.Name);
            cmd.Parameters.AddWithValue("@Email", Ad.EmailId);
            cmd.Parameters.AddWithValue("@Password", Ad.Password);
            cmd.Parameters.AddWithValue("@Mobile", Ad.MobileNumber);
            cmd.Parameters.AddWithValue("@Address", Ad.Address);
            cmd.Parameters.AddWithValue("@SuperAdminCode", Ad.SuperAdminCode);
            cmd.Parameters.AddWithValue("@PersonalCode", Ad.PersonalCode);
            cmd.Parameters.AddWithValue("@Organization", Ad.OrganizationName);
            cmd.Parameters.AddWithValue("@ExamCategory", Ad.ExamCategory);

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