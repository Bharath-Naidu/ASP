using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Repositary_file.Products_items;
using Repositary_file.Repositary_items;
 
namespace _22_9_2018_Authencation2_0
{
    public partial class ManageAllProducts : System.Web.UI.Page
    { Repositary r = new Repositary();
        List<Product> L;
        

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Context.User.IsInRole("Order"))
            {
                Response.Redirect("/Account/Lockout");
            }

            Table T = new Table();

            L = r.GetData();
            foreach (Product p in L)
            {
                T.BorderWidth = 2;
                TableRow TR = new TableRow();
                TR.BorderWidth = 2;
                TableCell TC = new TableCell();
                TC.BorderWidth = 2;

                Image im = new Image();
                im.ImageUrl = "~//" + p.URL.ToString();
                im.Width = 113;
                im.Height = 87;

                Label HL = new Label();
                HL.Text = p.Name.ToString();
                HL.ID = "Hyperlink_file";
                TC.Controls.Add(im);
                TC.Controls.Add(HL);
                TR.Cells.Add(TC);

              

                TableCell TC2 = new TableCell();
                TC2.BorderWidth = 2;
                TC2.Width = 100;
                TC2.Height = 100;
                HyperLink TC2HL = new HyperLink();
                TC2HL.Text = "PreView";
                TC2HL.NavigateUrl = "ProductItem.aspx?id=" + p.Id;
                TC2.Controls.Add(TC2HL);
                TR.Controls.Add(TC2);

                TableCell TC3 = new TableCell();
                TC3.BorderWidth = 2;
                TC3.Width = 100;
                TC3.Height = 100;

                Button TC3HL = new Button();
                TC3HL.Text = "Update";
                //TC3HL.OnClientClick = "UpdateTherecord";
                TC3HL.PostBackUrl = "~/UpdateProducts.aspx?id=" + p.Id;
                TC3.Controls.Add(TC3HL);
                TR.Controls.Add(TC3);

                TableCell TC4 = new TableCell();
                TC4.BorderWidth = 2;
                TC4.Width = 100;
                TC4.Height = 100;
                Button TC4HL = new Button();
                TC4HL.Text = "Delete";
                TC4HL.PostBackUrl = "~/DeleteProductItem.aspx?id=" + p.Id;
                TC4.Controls.Add(TC4HL);
                TR.Controls.Add(TC4);


                T.Rows.Add(TR);
            }
            PlaceHolderManage.Controls.Add(T);


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

        protected void New_Click(object sender, EventArgs e)
        {
            
        }
    }
    }