﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;

namespace TOF.SampleApps.WebForm
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // 應用程式啟動時執行的程式碼
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        void Application_End(object sender, EventArgs e)
        {
            //  應用程式關閉時執行的程式碼

        }

        void Application_Error(object sender, EventArgs e)
        {
            // 發生未處理錯誤時執行的程式碼

        }
    }
}
