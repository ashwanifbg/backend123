using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            Response.Write("hello from About  <BR/>");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("hello from Button1 <BR/>");

        }
    }
}