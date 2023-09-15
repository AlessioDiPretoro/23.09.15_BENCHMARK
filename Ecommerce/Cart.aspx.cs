using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //indextCart.Visible = false;

            if (!IsPostBack)
            {
                if (CartItem.cartList.Count > 0)
                //if (Session["cartList"] != "")
                {
                    //GridView1.DataSource = Session["cartList"];
                    GridView1.DataSource = CartItem.cartList;
                    GridView1.DataBind();
                }
                else
                {
                    isEmpty.InnerHtml = "carrello vuoto";
                    DeleteAll.Visible = false;
                }
            }
        }

        protected void DeleteAll_Click(object sender, EventArgs e)
        {
            CartItem.cartList.Clear();
            //Session["cartList"] = "";
            Response.Redirect("Cart");
        }

        protected void DeleteThis_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow gRow = btn.NamingContainer as GridViewRow;
            int i = gRow.RowIndex;
            CartItem.cartList.RemoveAt(i);
            //Response.Write($"did");
            Response.Redirect("Cart");
        }
    }
}