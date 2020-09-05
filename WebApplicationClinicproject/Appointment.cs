using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplicationClinicproject
{
    public class Appointment
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QA5TVH6;Initial Catalog=ClinicProject;User ID=bahaa;Password=1234");

        public int AddAppointment(String AppointmentDate, String DoctorEmail, String PatientEmail)
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
                com.CommandText = "insert into Appointment values(@AppointmentDate, @DoctorEmail, @PatientEmail)";
                com.Parameters.AddWithValue("@AppointmentDate ", AppointmentDate);
                com.Parameters.AddWithValue("@DoctorEmail ", DoctorEmail);
                com.Parameters.AddWithValue("@PatientEmail", PatientEmail);
               
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

        public DataTable GetAppointmentByPatient(string PatientEmail)
        {
            DataTable AppointmentByPatient = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                ////select * from Appointment where PatientEmail = @ PatientEmail (All table)
                /// CAST convert  AppointmentDate to nvarchar       بالعربي حذف الوقت 
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                com.CommandText = "select  CAST( a.AppointmentDate AS nvarchar(30)) as [AppointmentDate] , d.DoctorFullName from Appointment as a join Doctor as d on a.DoctorEmail = d.DoctorEmail where a.PatientEmail = @PatientEmail";
                com.Parameters.AddWithValue("@PatientEmail", PatientEmail);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(AppointmentByPatient);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return AppointmentByPatient;
        }

        public DataTable GetAppointmentByDoctor(string DoctorEmail)
        {
            DataTable AppointmentByDoctor = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                ////select * from Appointment where PatientEmail = @ PatientEmail (All table)
                /// CAST convert  AppointmentDate to nvarchar       بالعربي حذف الوقت 
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                com.CommandText = "select  CAST( a.AppointmentDate AS nvarchar(30)) as [AppointmentDate] , p.PatientFullName from Appointment as a join Patient as p on a.PatientEmail = p.PatientEmail where a.DoctorEmail = @DoctorEmail";
                com.Parameters.AddWithValue("@DoctorEmail", DoctorEmail);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(AppointmentByDoctor);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return AppointmentByDoctor;
        }

    }
}