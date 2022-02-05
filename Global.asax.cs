using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Admin_Login
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        
        void Session_Start(object sender, EventArgs e)
        {
            if (Application["counter"] == null)
            {
                Application.Add("counter", 0);

            }
            int icounter = Convert.ToInt32(Application["counter"]);
            icounter++;
            Application["counter"] = icounter.ToString();

        }
    }
}