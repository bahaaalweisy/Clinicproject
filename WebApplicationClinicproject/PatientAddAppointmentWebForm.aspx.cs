using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationClinicproject
{
    public partial class PatientAddAppointmentWebForm : System.Web.UI.Page
    {

        Doctor doctor = new Doctor();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DropDownListSpecialization.Items.Add("--- Select ---");

                foreach (var item in doctor.GetDoctorSpecializations())
                {
                    DropDownListSpecialization.Items.Add(item.ToString());
                }
            }


        }
       

      
       

        protected void DropDownListSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownListDoctors.Items.Add("--- Select ---");
            List<string> DoctorDetails = new List<string>();
            DoctorDetails = doctor.GetDoctorsBySpecializations(DropDownListSpecialization.SelectedItem.ToString());
            for (int i = 0; i < DoctorDetails.Count; i += 2)
            {
                DropDownListDoctors.Items.Add(new ListItem(DoctorDetails[i].ToString(), DoctorDetails[i + 1].ToString()));
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            if (appointment.AddAppointment(CalendarDate.SelectedDate.ToString("yyyy-MM-dd"), DropDownListDoctors.SelectedValue.ToString(), Session["PatientEmail"].ToString()) > 0)
            {
                Response.Write("<script>alert('Appointment Added');</script>");
            }
            else
            {
                Response.Write("<script>alert('Error');</script>");
            }
        }
    }
}