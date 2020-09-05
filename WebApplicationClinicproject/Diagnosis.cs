using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplicationClinicproject
{
    public class Diagnosis
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QA5TVH6;Initial Catalog=ClinicProject;User ID=bahaa;Password=1234");

        public int AddDiagnosis(String DoctorEmail, String PatientEmail, string DiagnosisDescription, string DiagnosisCost, string DiagnosisDate)
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
                com.CommandText = "insert into Diagnosis values(@DoctorEmail, @PatientEmail, @DiagnosisDescription, @DiagnosisCost, @DiagnosisDate)";
                com.Parameters.AddWithValue("@DoctorEmail ", DoctorEmail);
                com.Parameters.AddWithValue("@PatientEmail ", PatientEmail);
                com.Parameters.AddWithValue("@DiagnosisDescription", DiagnosisDescription);
                com.Parameters.AddWithValue("@DiagnosisCost", DiagnosisCost);
                com.Parameters.AddWithValue("@DiagnosisDate", DiagnosisDate);

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
        public DataTable GetDiagnosisByDate(string DoctorEmail, string DiagnosisDate)
        {
            DataTable AppointmentByPatient = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                com.CommandText = "select p.PatientFullName , d.DiagnosisDescription , d.DiagnosisCost from diagnosis as d join patient as p on d.patientemail = p.patientemail where d.DoctorEmail = @DoctorEmail and d.DiagnosisDate  = @DiagnosisDate";
                com.Parameters.AddWithValue("@DoctorEmail", DoctorEmail);
                com.Parameters.AddWithValue("@DiagnosisDate", DiagnosisDate);
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
       
        public DataSet GetDiagnosisByDateForPatient(string PatientEmail , string DiagnosisDate)
        {
            DataSet GetDiagnosisByDateForPatient = new DataSet();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                com.CommandText = "select r.DoctorFullName , d.DiagnosisDescription , d.DiagnosisCost from diagnosis as d join doctor as r on d.DoctorEmail = r.Doctoremail where d.patientemail = @patientemail and d.DiagnosisDate  = @DiagnosisDate ";
                com.Parameters.AddWithValue("@PatientEmail", PatientEmail);
                com.Parameters.AddWithValue("@DiagnosisDate", DiagnosisDate);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(GetDiagnosisByDateForPatient, "diagnosis");
               

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return GetDiagnosisByDateForPatient;
            
        }
       
    }
}