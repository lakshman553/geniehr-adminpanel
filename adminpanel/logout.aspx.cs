﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
//using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var AutheticationManager = HttpContext.Current.GetOwinContext().Authentication;
            AutheticationManager.SignOut();

            Response.Redirect("~/Login.aspx");

        }
    }
}