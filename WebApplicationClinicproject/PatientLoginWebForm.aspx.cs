using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationClinicproject
{
    public partial class PatientLoginWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Patient patient = new Patient();
                if (patient.Login(TextBoxPatientEmail.Text, TextBoxPatientPassword.Text) > 0)
                {

                    if (Session["PatientEmail"] == null)
                    {

                        Session.Add("PatientEmail", TextBoxPatientEmail.Text);
                    }
                    else
                    {
                        Session["PatientEmail"] = TextBoxPatientEmail.Text;


                    }
                 
                    Response.Redirect("PatientHomeWebForm.aspx");



                    /*
                    Response.Write("<script> alert('Done . . .')  </script>");
  
                    */
                }
                else
                {

                    LabelMessage.Text = "Invalid Email or Password";
                }


            }
        }
    }
}