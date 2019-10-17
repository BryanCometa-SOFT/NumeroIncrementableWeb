﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RequerimientoWeb
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtNro1.Text = "0";
                ViewState["valor"] = 0;
            }
            
        }
        int x;
        protected void btnNro1_Click(object sender, EventArgs e)
        {
            x = (int)ViewState["valor"] + 1;
            txtNro1.Text = x.ToString();
            ViewState["valor"] = x;
        }
    }
}