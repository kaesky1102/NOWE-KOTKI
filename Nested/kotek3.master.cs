using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NOWE_KOTKI
{
    public partial class kotek3 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./NestedMasterPage8.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Kotek4.aspx");

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("./NestedMasterPage8.aspx");

        }
    }
}