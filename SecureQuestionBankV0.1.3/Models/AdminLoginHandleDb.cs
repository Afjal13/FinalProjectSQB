using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SecureQuestionBankV0._1._3.Models
{
    public class AdminLoginHandleDb
    {
        public string SupAEmail;
        public string SupAPassword;
        public bool status = false;
        public string CheckEmail;
        public string CheckPassword;


        

        public SqlConnection con;
        public void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["DbService"].ToString();
            con = new SqlConnection(constring);
        }

        public bool SuperAdminLogin(LoginClass lc)
        {
            CheckEmail = lc.emailId;
            CheckPassword = lc.password;
            connection();
            con.Open();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("Select * from SupATReg", con);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        SupAEmail = (string)reader["Email"];
                        SupAPassword = (string)reader["Password"];
                        if (CheckEmail.Equals(SupAEmail) && CheckPassword.Equals(SupAPassword))
                        {
                            status = true;
                        }
                        else
                        {
                            status = false;
                        }
                    }
                }
            }

            return status;
        }

        public bool AdminLogin(LoginClass lc)
        {
            CheckEmail = lc.emailId;
            CheckPassword = lc.password;
            connection();
            con.Open();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("Select * from AdTReg", con);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        SupAEmail = (string)reader["Email"];
                        SupAPassword = (string)reader["Password"];
                        if (CheckEmail.Equals(SupAEmail) && CheckPassword.Equals(SupAPassword))
                        {
                            status = true;
                        }
                        else
                        {
                            status = false;
                        }
                    }
                }
            }

            return status;
        }
    


    public bool SubAdminLogin(LoginClass lc)
        {
            CheckEmail = lc.emailId;
            CheckPassword = lc.password;
            connection();
            con.Open();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("Select * from SubATReg", con);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        SupAEmail = (string)reader["Email"];
                        SupAPassword = (string)reader["Password"];
                        if (CheckEmail.Equals(SupAEmail) && CheckPassword.Equals(SupAPassword))
                        {
                            status = true;
                        }
                        else
                        {
                            status = false;
                        }
                    }
                }
            }

            return status;
        }

        public bool CentreAdminLogin(LoginClass lc)
        {
            CheckEmail = lc.emailId;
            CheckPassword = lc.password;
            connection();
            con.Open();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("Select * from CenATReg", con);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        SupAEmail = (string)reader["Email"];
                        SupAPassword = (string)reader["Password"];
                        if (CheckEmail.Equals(SupAEmail) && CheckPassword.Equals(SupAPassword))
                        {
                            status = true;
                        }
                        else
                        {
                            status = false;
                        }
                    }
                }
            }

            return status;
        }
    
}
}
