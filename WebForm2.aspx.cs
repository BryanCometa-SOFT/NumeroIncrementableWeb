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
            int x2;
            if (!IsPostBack)
            {
                txtNro1.Text = "0";
               
            }
            x2 = (int)Session["guarda"];
            txtNro1.Text =x2.ToString();
        }
        int x;
        protected void btnNro1_Click(object sender, EventArgs e)
        {
            /*
            x = (int)ViewState["guarda"] + 1;
            txtNro1.Text = x.ToString();
            ViewState["guarda"] = x;
            */
            if (Session["guarda"] == null)
            {
                Session["guarda"] = 0;
            }
            x = (int)Session["guarda"] + 1;
            txtNro1.Text = x.ToString();
            Session["guarda"] = x;

        }
    }
}