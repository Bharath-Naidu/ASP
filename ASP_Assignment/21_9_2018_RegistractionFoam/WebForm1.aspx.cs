using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _21_9_2018_RegistractionFoam
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[7] { new DataColumn("FirstName"), new DataColumn("LastName"), new DataColumn("Mobile number"), new DataColumn("Date Of Birth"), new DataColumn("Age"), new DataColumn("Gender"), new DataColumn("Country") });
                ViewState["value"] = dt;
                this.BindGrid();
            }
            //dt = new DataTable();
            //DataColumn dc1 = new DataColumn("First Name");
            //DataColumn dc2 = new DataColumn("Last Name");
            //dt.Columns.Add(dc1);
            //dt.Columns.Add(dc2);
            //DataRow dr1 = dt.NewRow();
            //GridView1.DataSource = dt;
            //GridView1.DataBind();
        }
        protected void BindGrid()
        {
            GridView1.DataSource = (DataTable)ViewState["value"];
            GridView1.DataBind();
        }
        //List<Data> L = new List<Data>();
        //static int i = 0;
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["value"];
            dt.Rows.Add(FIRSTNAME.Text, LASTNAME.Text,MOBILE.Text,DATEOFBIRTH.Text,AGE.Text, GENDER.SelectedValue, COUNTRY_LIST.SelectedValue);   
            ViewState["value"] = dt;
            this.BindGrid();
            FIRSTNAME.Text = string.Empty;
            LASTNAME.Text = string.Empty;
            MOBILE.Text = null;
        }

        protected void ALLSUBMISSIONS_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
        }
    }
}