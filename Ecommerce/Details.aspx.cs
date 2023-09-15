using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Products thisP = new Products();
                if (Request.QueryString["idDetails"] == null || Request.QueryString["idDetails"] == "0")
                {
                    Response.Redirect("Default.aspx");
                }

                int id = Convert.ToInt16(Request.QueryString["idDetails"]);
                foreach (Products p in Products.productList)
                {
                    if (p.Id == id)
                    {
                        thisP = p;
                        break;
                    }
                }
                img.Src = $"/Content/img/{thisP.Code}.jpg";
                price.InnerHtml = thisP.Price.ToString("C2");
                name.InnerHtml = thisP.Name;
                desc.InnerHtml = thisP.Description;
            }
        }

        protected void AddCart_Click(object sender, EventArgs e)
        {
            Products chosenP = new Products();
            int id = Convert.ToInt16(Request.QueryString["idDetails"]);
            foreach (Products p in Products.productList)
            {
                if (p.Id == id)
                {
                    chosenP = p;
                    break;
                }
            }
            int qty = int.Parse(DropDownList1.SelectedItem.Value);
            List<CartItem> cartList = Session["sessionCart"] as List<CartItem>;
            cartList.Add(new CartItem(qty, chosenP));

            Session["sessionCart"] = cartList;
            Response.Redirect("Default.aspx");
        }
    }
}