using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositary_file.Products_items;
using Repositary_file.Repositary_items;
namespace _22_9_2018_Authencation2._0
{
    public partial class DeleteProductItem : System.Web.UI.Page
    {
        Repositary r = new Repositary();
        List<Product> L;
        int itemId;
        protected void Page_Load(object sender, EventArgs e)
        {
            L = r.GetData();
            itemId = Convert.ToInt32(Request.QueryString["id"].ToString());
            foreach(Product P in L)
            {
                if(P.Id==itemId)
                {
                    Image1.ImageUrl ="~//" +P.URL;
                    Label1.Text = P.Name;
                    Label2.Text = P.Price.ToString();
                    Label3.Text = P.Description;
                
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            r.DeleteOperaction(itemId);
            Response.Redirect("/ManageAllProducts");
        }
    }
}