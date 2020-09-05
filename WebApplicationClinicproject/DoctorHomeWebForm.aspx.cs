using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationClinicproject
{
    public partial class DoctorHomeWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["DoctorEmail"] != null)
            {

                LabelEmail.Text = Session["DoctorEmail"].ToString();
                Doctor doctor = new Doctor();

                LabelName.Text = doctor.GetDoctorFullName(Session["DoctorEmail"].ToString());
            }
            else
            {
                Response.Redirect("Default.aspx");

            }
        }
    }
}