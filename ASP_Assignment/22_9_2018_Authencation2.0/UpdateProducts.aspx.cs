using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Repositary_file.Products_items;
using Repositary_file.Repositary_items;

namespace _22_9_2018_Authencation2._0
{
    public partial class UpdateProducts : System.Web.UI.Page
    {
        int id;
        Repositary obj = new Repositary();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repositary obj = new Repositary();
            id = Convert.ToInt32(Request.QueryString["id"].ToString());
            //Repositary obj=new Repositary(); 
            if (!IsPostBack)
            {
                List<Product> L = obj.GetData();
                foreach (Product P in L)
                {
                    if (P.Id == id)
                    {
                        Image2.ImageUrl = "~//" + P.URL;
                        Name.Text = P.Name;
                        
                        List<BrandItems> B = obj.GetBrand();
                        foreach (BrandItems BI in B)
                        {
                            Brands.Items.Add(new ListItem(BI.BrandName, BI.BrandId.ToString()));
                        }
                        price.Text = P.Price.ToString();
                        dec.Text = P.Description;

                    }
                }
            }
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {

            Label1.Text=obj.UpdateProduct(id, Name.Text, Convert.ToInt32(Brands.SelectedValue.ToString()), Convert.ToInt32(price.Text.ToString()), dec.Text);
            Label1.Visible = true;
        }



    }
}