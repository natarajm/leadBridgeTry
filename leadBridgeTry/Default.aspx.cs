﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Collections;

namespace leadBridgeTry
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static ArrayList HelloWorld(string strabc1)
        {
            ArrayList arr = new ArrayList();
            arr.Add("abc");
            arr.Add("123");
            arr.Add("fff");
            return arr;
        }
    }
}
