using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20_9_2018_ViewState_Examples
{
    public partial class Viewstate : System.Web.UI.Page
    {
       
        protected void Page_PreInit(object sender, EventArgs e)
        {
            ViewState["xyz"] = Convert.ToString(ViewState["xyz"]) + "<br/>" + "PreInit";
            Label1.Text = Convert.ToString(ViewState["xyz"]);
        } 

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            ViewState["xyz"] = Convert.ToString(ViewState["xyz"]) + "<br/>" + "InitComplete";
            Label1.Text = Convert.ToString(ViewState["xyz"]);
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            ViewState["xyz"] = Convert.ToString(ViewState["xyz"]) + "<br/>" + "Init";
            Label1.Text = Convert.ToString(ViewState["xyz"]);
        }
        protected override void OnPreLoad(EventArgs e)
        {
            ViewState["xyz"] = Convert.ToString(ViewState["xyz"]) + "<br/>" + "OnPreLoad";
            Label1.Text = Convert.ToString(ViewState["xyz"]);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["xyz"] = Convert.ToString(ViewState["xyz"]) + "<br/>" + "Page_Load";
            Label1.Text = Convert.ToString(ViewState["xyz"]);
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            ViewState["xyz"] = Convert.ToString(ViewState["xyz"]) + "<br/>" + "Button clicked";
            Label1.Text = Convert.ToString(ViewState["xyz"]);
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            ViewState["xyz"] = Convert.ToString(ViewState["xyz"]) + "<br/>" + "LoadComplete";
            Label1.Text = Convert.ToString(ViewState["xyz"]);
        }
        protected override void OnPreRender(EventArgs e)
        {
            ViewState["xyz"] = Convert.ToString(ViewState["xyz"]) + "<br/>" + "PreRender";
            Label1.Text = Convert.ToString(ViewState["xyz"]);
        }
        protected void OnSaveStateComplete(object sender, EventArgs e)
        {
            ViewState["xyz"] = Convert.ToString(ViewState["xyz"]) + "<br/>" + "OnSaveStateComplete";
            Label1.Text = Convert.ToString(ViewState["xyz"]);
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            ViewState["xyz"] = Convert.ToString(ViewState["xyz"]) + "<br/>" + "Unload";
            Label1.Text = Convert.ToString(ViewState["xyz"]);
        }

      
    }
}