using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace WebApplicationClinicproject
{
    public class Patient
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QA5TVH6;Initial Catalog=ClinicProject;User ID=bahaa;Password=1234");

        public int Signup(String PatientEmail, String PatientFullName, String PatientMobile, String PatientPassword)
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
                com.CommandText = "insert into Patient values(@PatientEmail, @PatientFullName, @PatientMobile,@PatientPassword)";
                com.Parameters.AddWithValue("@PatientEmail ", PatientEmail);
                com.Parameters.AddWithValue("@PatientFullName ", PatientFullName);
                com.Parameters.AddWithValue("@PatientMobile", PatientMobile);
                com.Parameters.AddWithValue("@PatientPassword ", PatientPassword);
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
        public int Login(String PatientEmail, String PatientPassword)
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
                com.CommandText = "select count(*) from Patient where PatientEmail= @PatientEmail and PatientPassword=@PatientPassword";
                com.Parameters.AddWithValue("@PatientEmail ", PatientEmail);
                com.Parameters.AddWithValue("@PatientPassword ", PatientPassword);
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
        public string GetPatientFullName(String PatientEmail)
        {

            string PFullName = " ";


            try
            {
                if (con.State == ConnectionState.Closed)
                {

                    con.Open();

                }

                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                com.CommandText = "select PatientFullName from Patient where PatientEmail= @PatientEmail";
                com.Parameters.AddWithValue("@PatientEmail ", PatientEmail);

                SqlDataReader Reader = com.ExecuteReader();
                if (Reader.Read())//اذا رجعلي القيمة لللاسم  true
                {

                    PFullName = Reader["PatientFullName"].ToString();
                }

            }
            catch (Exception ex)
            {


            }

            finally
            {

                con.Close();
            }


            return PFullName;


        }
        public List<string> GetPatients_Name_Email()
        {
            List<string> PatientDetails = new List<string>();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                com.CommandText = "select PatientFullName , PatientEmail  from Patient ";
                SqlDataReader Reader = com.ExecuteReader();
                while (Reader.Read())
                {
                    PatientDetails.Add(Reader["PatientFullName"].ToString());
                    PatientDetails.Add(Reader["PatientEmail"].ToString());
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return PatientDetails;
        }

    }
}
