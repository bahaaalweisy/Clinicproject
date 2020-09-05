using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationClinicproject
{
    public partial class PatientSignupWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSignup_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            if (patient.Signup(TextBoxEmail.Text, TextBoxFullName.Text, TextBoxMobile.Text, TextBoxPassword.Text) > 0)
            {

                Response.Write("<script> alert('Patient Added') </script>");
            }
            else
            {

                Response.Write("<script> alert('Error') </script>");


            }
        }
    }
}