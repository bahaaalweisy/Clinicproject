using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationClinicproject
{
    public partial class PatientViewAppointmentWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonView_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            GridViewAppointments.DataSource = appointment.GetAppointmentByPatient(Session["PatientEmail"].ToString());///من وين البيانات تجيبها
            GridViewAppointments.DataBind();//////جيب البيانات
        }
    }
}