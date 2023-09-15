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
                int id = Convert.ToInt16(Request.QueryString["idDetails"]);
                foreach (Products p in Products.productList)
                {
                    if (p.Id == id)
                    {
                        thisP = p;
                        break;
                    }
                    // else
                    // {
                    //     Response.Write("articolo non trovato");
                    // }
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
            // List<CartItem> list = (List<CartItem>)Session["cartList"];
            // list.Add(new CartItem(qty, chosenP));
            // Session["cartList"] = list;
            CartItem.cartList.Add(new CartItem(qty, chosenP));
            Response.Redirect("Default.aspx");
        }
    }
}