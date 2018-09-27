using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _22_9_2018_Authentication
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          if(Context.User.IsInRole("Order"))
            {
                Response.Redirect("/Account/Lockout");
            }
          
        }
    }
}