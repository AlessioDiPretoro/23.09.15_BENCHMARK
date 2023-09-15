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
                if (Session["sessionCart"] == null)
                {
                    //   Response.Write("NO sessione");
                    List<CartItem> cartListUser = new List<CartItem>();
                    Session["sessionCart"] = cartListUser;
                }

                List<CartItem> cartList = Session["sessionCart"] as List<CartItem>;

                if (cartList.Count > 0)
                {
                    GridView1.DataSource = cartList;
                    GridView1.DataBind();
                    double tot = 0;
                    foreach (CartItem c in cartList)
                    {
                        tot += c.Products.Price * c.quantity;
                    }
                    totalPrice.InnerHtml = $"Totale carrello:{tot.ToString("C2")} ";
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
            List<CartItem> cartList = Session["sessionCart"] as List<CartItem>;
            cartList.Clear();
            Session["cartList"] = cartList;
            Response.Redirect("Cart");
        }

        protected void DeleteThis_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow gRow = btn.NamingContainer as GridViewRow;
            int i = gRow.RowIndex;
            List<CartItem> cartList = Session["sessionCart"] as List<CartItem>;
            cartList.RemoveAt(i);
            Session["cartList"] = cartList;
            Response.Redirect("Cart");
        }
    }
}