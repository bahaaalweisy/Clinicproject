using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationClinicproject
{
    public partial class DoctorAddDiagnosisWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            List<string> PatientDetails = new List<string>();
            DropDownListPatient.Items.Add("--- Select ---");
            PatientDetails = patient.GetPatients_Name_Email();
            for (int i = 0; i < PatientDetails.Count; i += 2)///   الزوجي بنزل فيه الاسم والفردي بنزل فيه الايميل
            {
                DropDownListPatient.Items.Add(new ListItem(PatientDetails[i].ToString(), PatientDetails[i + 1].ToString()));
            }


        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Diagnosis diagnosis = new Diagnosis();
            if (diagnosis.AddDiagnosis(Session["DoctorEmail"].ToString(), DropDownListPatient.SelectedValue.ToString(), TextBoxDescription.Text, TextBoxCost.Text, DateTime.Now.Date.ToString("yyyy-MM-dd")) > 0)
            {
                Response.Write("<script>alert('Diagnosis Added');</script>");
            }
            else
            {
                Response.Write("<script>alert('Error');</script>");
            }
        }
    }
}