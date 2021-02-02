using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace NOWE_KOTKI
{
    public partial class NestedMasterPage5 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "basia" && TextBox2.Text == "serek123")

            {
                FormsAuthenticationTicket bilet = new FormsAuthenticationTicket(1, "basia", DateTime.Now, DateTime.Now.AddMinutes(30), false,FormsAuthentication.FormsCookiePath);
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(bilet));
                Response.Cookies.Add(cookie);

                TextBox1.Visible = false;
                TextBox2.Visible = false;
                TextBox3.Visible = false;
                TextBox4.Visible = false;
                this.Button1.Visible = false;
                Button2.Visible = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Visible == true)
            Response.Redirect("./Protected/Hidden.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            this.Button2.Visible = false;
            Button1.Visible = true;
        }
    }
}