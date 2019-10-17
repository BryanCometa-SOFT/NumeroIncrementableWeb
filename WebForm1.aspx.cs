using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RequerimientoWeb
{
    public partial class FormNumeroVariable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                txtNro1.Text = "0";
                int x2=0;
                if (x == 0)
                {
                    x2 = (int)Session["guarda"];
                    txtNro1.Text = x2.ToString();
                }
            }
           
            

        }
        int x = 0;
        protected void btnNro1_Click(object sender, EventArgs e)
        {
            //variable de estado
            /*
            x=(int)ViewState["guarda"]+1;
            txtNro1.Text = x.ToString();
            ViewState["guarda"] = x;
            */

            //variable de sesión
            if (Session["guarda"]==null)
            {
                Session["guarda"] = 0;
            }
            x = (int)Session["guarda"] + 1;
            txtNro1.Text = x.ToString();
            Session["guarda"] = x;
        }
    }
}