using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationClinicproject
{
    public partial class DoctorSignupWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                DropDownListSpecilization.Items.Add("--- Select ---");
                DropDownListSpecilization.Items.Add("Children");
                DropDownListSpecilization.Items.Add("Bones");


            }



        }

        protected void ButtonSignup_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            if (doctor.Signup(TextBoxEmail.Text, TextBoxFullName.Text, TextBoxMobile.Text, TextBoxPassword.Text, DropDownListSpecilization.SelectedItem.ToString()) > 0)
            {

                Response.Write("<script> alert('Doctor Added') </script>");
            }
            else
            {

                Response.Write("<script> alert('Error') </script>");


            }



        }
    }
}