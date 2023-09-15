using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Session_OnStart(object sender, EventArgs e)
        {
            // non funziona?
            //if (Session["sessionCart"] == null)
            //{
            //    Response.Write("NO sessione");
            //    List<CartItem> cartListUser = new List<CartItem>();
            //    Session["sessionCart"] = cartListUser;
            //}
        }
    }
}