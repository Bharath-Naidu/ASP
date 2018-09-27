using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Repositary_file.Repositary_items;
namespace _22_9_2018_Authencation2._0
{
    public partial class InsertNewProduct : System.Web.UI.Page
    {
        Repositary r = new Repositary();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<BrandItems> B = r.GetBrand();
            foreach (BrandItems BI in B)
            {
                DropDownList1.Items.Add(new ListItem(BI.BrandName, BI.BrandId.ToString()));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Label1.Text=r.InsertNewProduct(Name.Text, Convert.ToInt32(DropDownList1.SelectedValue.ToString()),Convert.ToInt32(Price.Text.ToString()),Dec.Text);
            Label1.Visible = true;
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}