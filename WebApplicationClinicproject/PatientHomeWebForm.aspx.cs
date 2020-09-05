using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationClinicproject
{
    public partial class PatientHomeWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PatientEmail"] != null)
            {

                LabelEmail.Text = Session["PatientEmail"].ToString();
                Patient patient = new Patient();

                LabelName.Text = patient.GetPatientFullName(Session["PatientEmail"].ToString());
            }
            else 
            {
                Response.Redirect("Default.aspx");
                
            }



        }
    }
}