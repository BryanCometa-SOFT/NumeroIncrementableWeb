using System;
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
                Session["guardar"] = 0;
            }
            
        }
        int x;
        protected void btnNro1_Click(object sender, EventArgs e)
        {
            /*
            x = (int)ViewState["guarda"] + 1;
            txtNro1.Text = x.ToString();
            ViewState["guarda"] = x;
            */
            x = (int)Session["guarda"] + 1;
            txtNro1.Text = x.ToString();
            Session["guarda"] = x;

        }
    }
}