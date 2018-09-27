using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositary_file.Products_items;
using Repositary_file.Repositary_items;

namespace _22_9_2018_Authentication2_0
{
    public partial class ProductList : System.Web.UI.Page
    {
        Repositary r = new Repositary();
        List<Product> L;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Context.User.IsInRole("Order"))
            {
                Response.Redirect("/Account/Lockout");
            }

            Table T = new System.Web.UI.WebControls.Table();

            L = r.GetData();
            foreach (Product p in L)
            {
                TableRow TR = new TableRow();
                TableCell TC = new TableCell();
                T.BorderWidth = 2;
                TR.BorderWidth = 2;
                TC.BorderWidth = 2;
                Image im = new Image();
                im.ImageUrl = "~//" + p.URL.ToString();
                im.Width = 250;
                im.Height = 250;
                Label l = new Label();
                l.Text = "Product Name:";
                HyperLink HL = new HyperLink();
                HL.Text = p.Name.ToString();
                Label l1 = new Label();
                l1.Text = "Price Of Product:";
                HyperLink HL2 = new HyperLink();
                HL2.Text = p.Price.ToString();
                HL.ID = "Hyperlink_file";
                HL.NavigateUrl = "ProductItem.aspx?id=" + p.Id;
                TC.Width = 600;
                TC.Height = 300;
                TC.Controls.Add(im);
                TC.Controls.Add(l);
                TC.Controls.Add(HL);
                //TC.Controls.Add( );
                TC.Controls.Add(new LiteralControl("<br/>"));
                TC.Controls.Add(l1);
                TC.Controls.Add(HL2);
                TR.Cells.Add(TC);
                T.Rows.Add(TR);
            }
            PlaceHolder1.Controls.Add(T);

        }
        protected void btnSearchBar_Click(object sender, EventArgs e)
        {
            string value = txtSearch.Text.Trim();
            String[] itemsGotFromDB = new string[100];
            itemsGotFromDB = r.SearchItem(value);

            foreach (String str in itemsGotFromDB)
            {
                HyperLink HL = new HyperLink();
                HL.Text = str;
                foreach (Product p in L)
                {
                    if (p.Name.Equals(str))
                    {
                        HL.NavigateUrl = "ProductItem.aspx?id=" + p.Id;
                    }
                }
                PlaceHolder2.Controls.Add(HL);
            }


        }


    }
}



 