using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationClinicproject
{
    public partial class DoctorLoginWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            
            if (Page.IsValid)
            {
                Doctor doctor = new Doctor();
                if (doctor.Login(TextBoxDoctorEmail.Text, TextBoxDoctorPassword.Text) > 0)
                {

                    if (Session["DoctorEmail"] == null)
                    {

                        Session.Add("DoctorEmail", TextBoxDoctorEmail.Text);
                    }
                    else
                    {
                        Session["DoctorEmail"] = TextBoxDoctorEmail.Text;


                    }

                    Response.Redirect("DoctorHomeWebForm.aspx");



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