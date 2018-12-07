using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SecureQuestionBankV0._1._3.Models
{
    public class CentreAdminHandleDb
    {
        public SqlConnection con;
        public void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["DbService"].ToString();
            con = new SqlConnection(constring);
        }

        public bool AddCenterAdmin(CentreAdmin CenA)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AddCentreAminRegP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", CenA.Name);
            cmd.Parameters.AddWithValue("@Email", CenA.EmailId);
            cmd.Parameters.AddWithValue("@Password", CenA.Password);
            cmd.Parameters.AddWithValue("@Mobile", CenA.MobileNumber);
            cmd.Parameters.AddWithValue("@Address", CenA.Address);
            cmd.Parameters.AddWithValue("@Organization", CenA.OrganizationName);
            cmd.Parameters.AddWithValue("@EmisCode", CenA.EmisCode);
            cmd.Parameters.AddWithValue("@ExamCategory", CenA.ExamType);
            cmd.Parameters.AddWithValue("@SuperAdminCode", CenA.SuperAdminCode);

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