using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplicationClinicproject
{
    public class Doctor
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QA5TVH6;Initial Catalog=ClinicProject;User ID=bahaa;Password=1234");

        public int Signup(String DoctorEmail, String DoctorFullName, String DoctorMobile, String DoctorPassword, String DoctorSpecilization)
        {

            int count = 0;


            try
            {
                if (con.State == ConnectionState.Closed)
                {

                    con.Open();

                }

                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into Doctor values(@DoctorEmail, @DoctorFullName, @DoctorMobile,@DoctorPassword, @DoctorSpecilization)";
                com.Parameters.AddWithValue("@DoctorEmail ", DoctorEmail);
                com.Parameters.AddWithValue("@DoctorFullName ", DoctorFullName);
                com.Parameters.AddWithValue("@DoctorMobile", DoctorMobile);
                com.Parameters.AddWithValue("@DoctorPassword ", DoctorPassword);
                com.Parameters.AddWithValue("@DoctorSpecilization ", DoctorSpecilization);
                count = com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {


            }

            finally
            {

                con.Close();
            }


            return count;


        }
        public int Login(String DoctorEmail, String DoctorPassword)
        {

            int count = 0;


            try
            {
                if (con.State == ConnectionState.Closed)
                {

                    con.Open();

                }

                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                com.CommandText = "select count(*) from Doctor where DoctorEmail= @DoctorEmail and DoctorPassword=@DoctorPassword";
                com.Parameters.AddWithValue("@DoctorEmail ", DoctorEmail);
                com.Parameters.AddWithValue("@DoctorPassword ", DoctorPassword);
                count = Convert.ToInt32(com.ExecuteScalar());

            }
            catch (Exception ex)
            {


            }

            finally
            {

                con.Close();
            }


            return count;


        }

        public List<string> GetDoctorSpecializations()
        {
            List<string> DoctorSpecializations = new List<string>();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                com.CommandText = "select distinct DoctorSpecilization from Doctor";
                SqlDataReader Reader = com.ExecuteReader();
                while (Reader.Read())
                {
                    DoctorSpecializations.Add(Reader["DoctorSpecilization"].ToString());
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return DoctorSpecializations;
        }


        public List<string> GetDoctorsBySpecializations(string DoctorSpecilization)
        {
            List<string> DoctorDetails = new List<string>();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                com.CommandText = "select DoctorFullName , DoctorEmail  from Doctor where DoctorSpecilization = @DoctorSpecilization";
                com.Parameters.AddWithValue("@DoctorSpecilization", DoctorSpecilization);
                SqlDataReader Reader = com.ExecuteReader();
                while (Reader.Read())
                {
                    DoctorDetails.Add(Reader["DoctorFullName"].ToString());
                    DoctorDetails.Add(Reader["DoctorEmail"].ToString());
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return DoctorDetails;
        }



        public string GetDoctorFullName(string DoctorEmail)
        {
            string DFullName = "";
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                com.CommandText = "select DoctorFullName from Doctor where DoctorEmail = @DoctorEmail ";
                com.Parameters.AddWithValue("@DoctorEmail", DoctorEmail);

                SqlDataReader Reader = com.ExecuteReader();
                if (Reader.Read())
                {
                    DFullName = Reader["DoctorFullName"].ToString();
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return DFullName;
        }

    }
}