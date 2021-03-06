﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationClinicproject
{
    public partial class DoctorViewDiagnosisWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonView_Click(object sender, EventArgs e)
        {
            Diagnosis diagnosis = new Diagnosis();
            GridViewDaiagnosis.DataSource = diagnosis.GetDiagnosisByDate(Session["DoctorEmail"].ToString(), CalendarDiagnosisDate.SelectedDate.ToString("yyyy-MM-dd"));
            GridViewDaiagnosis.DataBind();

        }
    }
}