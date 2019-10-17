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
            
        }
        int x = 0;
        protected void btnNro1_Click(object sender, EventArgs e)
        {
            x++;
            txtNro1.Text = x.ToString();
        }
    }
}