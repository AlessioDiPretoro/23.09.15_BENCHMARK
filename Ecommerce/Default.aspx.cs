using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Products> allProducts = Products.GetAllProducts();
                Repeater1.DataSource = allProducts;
                Repeater1.DataBind();
            }
        }
    }
}