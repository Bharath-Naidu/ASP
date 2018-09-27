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
    public partial class ProductItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Repositary r = new Repositary();
            List<Product> L = r.GetData();
            List<BrandItems> listofbrands = r.GetBrand();
            int itemId = Convert.ToInt32(Request.QueryString["id"].ToString());
            foreach(Product P in L)
            {
                if(P.Id==itemId)
                {
                    Image1.ImageUrl ="~//" +P.URL;
                    Label1.Text = P.Name;
                    Label2.Text = P.Price.ToString();
                    Label3.Text = P.Description;
                    foreach(BrandItems B in listofbrands)
                    {
                        if(P.Bid==B.BrandId)
                        {
                            Label4.Text = B.BrandName;
                        }
                    }
                }
            }
        }
    }
}